/****************************************************
    文件：SceneSystem.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using System.Collections;
using Cysharp.Threading.Tasks;
using QFramework;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSystem : AbstractSystem
{
    
    
    protected override void OnInit()
    {
        
    }

    public void LoadMain()
    {
        YFramework.MonoGlobal.Instance.StartCoroutine(CorLoad(SceneName.Main));
    }

    IEnumerator CorLoad(SceneName sceneName)
    {
        var handle = SceneManager.LoadSceneAsync(sceneName.ToString());
        this.SendEvent(new LoadingUI(){Active = true});
        handle.allowSceneActivation = false; 
        GameController.Instance.AddUpdateCall(LogProgrress);
        //在关闭了允许场景跳转的时候，handle是一直等待中
        //yield return handle;
        yield return UniTask.WaitUntil(() => handle.progress >= 0.9f);
        handle.allowSceneActivation = true;
        GameController.Instance.RemoveUpdateCall(LogProgrress);
        
        void LogProgrress()
        {
            Debug.Log(handle.progress);
        }
    }

    
    
    private enum SceneName
    {
        Loading,
        Login,
        Main,
    }
}