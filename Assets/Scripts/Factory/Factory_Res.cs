/****************************************************
    文件：ResFactory.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/


using UnityEngine;

public static class Factory_Res  
{
    public static GameObject GetLoadingUI()
    {
        var prefab = Resources.Load<GameObject>("Prefabs/Loading");
        return prefab;
    }
}