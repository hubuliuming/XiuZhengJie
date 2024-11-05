/****************************************************
    文件：GameStart.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using QFramework;
using UnityEngine;
using UnityEngine.UI;

public class GameLogin : MonoBehaviour,IController 
{
    private Button _btnLogin;

    private void Awake()
    {
        _btnLogin = transform.Find("BtnLogin").GetComponent<Button>();
        _btnLogin.onClick.AddListener(LoginClick);
        this.RegisterEvent<LoadingUI>(ChangeLoadUI);
    }

    private void LoginClick()
    {
        this.GetSystem<SceneSystem>().LoadMain();
    }
    private void OnDestroy()
    {
        _btnLogin.onClick.RemoveListener(LoginClick);
    }

    private void ChangeLoadUI(LoadingUI loadingUI)
    {
        if (loadingUI.Active)
        {
            Factory_Res.GetLoadingUI().InstantiateWithParent(transform);
        }
    }

    public IArchitecture GetArchitecture()
    {
        return Game.Game.Interface;
    }
}