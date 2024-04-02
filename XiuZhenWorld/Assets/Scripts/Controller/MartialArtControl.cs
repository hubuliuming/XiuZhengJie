/****************************************************
    文件：MartialartControl.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：武功功法
*****************************************************/

using UnityEngine;
using UnityEngine.UI;
using YFramework;

public class MartialArtControl : MonoBehaviour,IController
{
    public GameObject[] colums;
    private MartialArtModel _model;
    
    
    
    private void Start()
    {
        _model = this.GetModel<MartialArtModel>();
        for (int i = 0; i < colums.Length; i++)
        {
            for (int k = 0; k < colums[i].transform.childCount; k++)
            {
                var child = colums[i].transform.GetChild(k);
                Debug.Log(_model);
                child.GetComponentInChildren<Text>().text = _model.columAritDic[i][k].Name;
                //todo，需要缓存一下chlid数据和添加脚本
            }
        }
    }

    public IArchitecture GetArchitecture()
    {
        return Game.Interface;
    }
}