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
using YFramework.UI;

namespace MartialArt
{
    public class MartialArtItem : MonoBehaviour,IPointerClickHandler,ICanSendEvent
    {
        private ItemClickEvent _event;
        private ItemData _data;
        private bool _select;

        public bool Select
        {
            get => _select;
            private set
            {
                _select = value;
                _circleImage.color = _select ? _selectColor : _normalColor;
            }
        }

        private Color _selectColor = Color.green;
        private Color _normalColor = Color.grey;

        private CircleImage _circleImage;
    
    
        public void Init(int id)
        {
            _event = new ItemClickEvent();
            _data = new ItemData();
            _data.id = id;
            _data.pos = transform.position;
            _select = false;
            _circleImage = GetComponent<CircleImage>();
            _circleImage.color = _normalColor;
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            Select = !Select;
            _data.select = Select;
            _event.data = _data;
            this.SendEvent(_event);
        }

        public void OnReset()
        {
            Select = false;
        }

        public IArchitecture GetArchitecture()
        {
            return Game.Interface;
        }
    }
}