/****************************************************
    文件：MartialartControl.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：武功功法
*****************************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;


namespace MartialArt
{
    public partial class MartialArtControl : ViewController,IController
    {
        public GameObject[] colums;
        private MartialArtModel _model;
        private Dictionary<int, MartialArtItem> _itemDic;
        private List<MartialArtItem> _selectItem;

        private void Start()
        {
            _model = this.GetModel<MartialArtModel>();
            _itemDic = new Dictionary<int, MartialArtItem>();
            //这里容量应该设置为创造武学最大的上限
            _selectItem = new List<MartialArtItem>(23);
            int id = 0;
            for (int i = 0; i < colums.Length; i++)
            {
                for (int k = 0; k < colums[i].transform.childCount; k++)
                {
                    var child = colums[i].transform.GetChild(k);
                    child.GetComponentInChildren<Text>().text = _model.columAritDic[i][k].Name;
                    var item = child.gameObject.AddComponent<MartialArtItem>();
                    item.Init(id);
                    _itemDic.Add(id,item);
                    id++;
                }
            }

            this.RegisterEvent<ItemClickEvent>(OnClickItem);

            BtnExcute.onClick.AddListener(Submit);
            BtnBack.onClick.AddListener(ResetAll);

            this.RegisterEvent<ResetAllEvent>(d=>ResetAll());
        }

        private void OnClickItem(ItemClickEvent data)
        {
            if (data.data.select)
            {
                _selectItem.Add(_itemDic[data.data.id]);
            }
            else
            {
                _selectItem.Remove(_itemDic[data.data.id]);
            }
        }

        /// <summary>
        ///  提交数据，模拟运行
        /// </summary>
        private void Submit()
        {
            StartCoroutine(Sub());
            IEnumerator Sub()
            {
                Mask.SetActive(true);
                var pos = GetPos(1);
                for (int i = 0; i < pos.Count; i++)
                {
                    Line.positionCount = i +1;
                    Line.SetPosition(i,pos[i]);
                    yield return new WaitForSeconds(0.02f);
                }
                ResetItem();
                Result.Open();
            }
        }
        
        /// <summary>
        /// 计算切割好的位置
        /// </summary>
        /// <param name="interval">隔多少距离生成一个点位</param>
        /// <returns></returns>
        private List<Vector3> GetPos(int interval)
        {
            List<Vector3> pos = new List<Vector3>(_selectItem.Count * interval);
            var z = _selectItem[0].Position().z;
            for (int i = 0; i < _selectItem.Count -1; i++)
            {
                var curPos = _selectItem[i].Position2D();
                var nextPos = _selectItem[i + 1].Position2D();
                var offset = nextPos - curPos;
                for (int j = 0; j < offset.magnitude/interval; j++)
                {
                    var offsetPos = offset / (offset.magnitude / interval);
                    var newPos = curPos + offsetPos * j;
                    pos.Add(new Vector3(newPos.x,newPos.y,z));
                }
            }
           
            return pos;
        }

        private void ResetItem()
        {
            foreach (var item in _selectItem)
            {
                item.OnReset();
            }
            _selectItem.Clear();
        }

        private void ResetAll()
        {
            ResetItem();
            Mask.gameObject.SetActive(false);
            Line.positionCount = 0;
        }
    
        public IArchitecture GetArchitecture()
        {
            return Game.Interface;
        }
    }

    internal struct ItemData
    {
        public int id;
        public bool select;
        public Vector3 pos;
    }
    
}