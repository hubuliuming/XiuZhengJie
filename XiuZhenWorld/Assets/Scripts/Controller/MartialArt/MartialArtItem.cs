/****************************************************
    文件：MartialArtItem.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using System;
using UnityEngine;
using UnityEngine.EventSystems;
using QFramework;

public class MartialArtItem : MonoBehaviour,IController,IPointerClickHandler
{
    private int _id;
    private string _name;


    public void Init(int id)
    {
        _id = id;
        this.RegisterEvent<int>((i => Debug.Log(i)));
        
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        
    }

    public IArchitecture GetArchitecture()
    {
        return Game.Interface;
    }
}