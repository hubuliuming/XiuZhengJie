/****************************************************
    文件：GameController.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using System;
using System.Collections.Generic;
using YFramework.Kit.Singleton;

public class GameController : MonoSingleton<GameController>
{
    private List<Action> _onStarts;
    private List<Action> _onUpdates;
    private List<Action> _cacheUpdates;
    public List<Action> OnDestroys;

    public void Init()
    {
        _onStarts = new List<Action>();
        _onUpdates = new List<Action>();
        OnDestroys = new List<Action>();

        _cacheUpdates = new List<Action>();
    }
    private void Start()
    {
        if (_onStarts.Count > 0)
        {
            foreach (var ac in _onStarts)
            {
                ac?.Invoke();
            }
            _onStarts.Clear();
        }
    }

    private void Update()
    {
        if (_onUpdates.Count > 0)
        {
            foreach (var ac in _onUpdates)
            {
                ac?.Invoke();
            }

            if (_cacheUpdates.Count > 0)
            {
                foreach (var ac in _cacheUpdates)
                {
                    _onUpdates.Remove(ac);
                }
                _cacheUpdates.Clear();
            }
        }
    }

    public void AddStartCall(Action ac)
    {
        _onStarts.Add(ac);
    }

    public void AddUpdateCall(Action ac)
    {
        _onUpdates.Add(ac);
    }

    public void RemoveUpdateCall(Action ac)
    {
        if (_onUpdates.Contains(ac))
        {
            _cacheUpdates.Add(ac);
        }
    }
}