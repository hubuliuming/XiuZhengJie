/****************************************************
    文件：MartialartControl.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：武功功法
*****************************************************/

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using QFramework;

public class MartialArtControl : MonoBehaviour,IController
{
    public GameObject[] colums;
    private MartialArtModel _model;
    private Dictionary<int, MartialArtItem> _itemDic;


    private void Start()
    {
        _model = this.GetModel<MartialArtModel>();
        _itemDic = new Dictionary<int, MartialArtItem>();
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
    }

    public IArchitecture GetArchitecture()
    {
        return Game.Interface;
    }
}