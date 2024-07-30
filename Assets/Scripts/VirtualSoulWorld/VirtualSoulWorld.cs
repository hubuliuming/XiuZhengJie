/****************************************************
    文件：VirtualSoulWorld.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using QFramework;

namespace Game
{
    public class VirtualSoulWorld : Architecture<VirtualSoulWorld>
    {
        protected override void Init()
        {
            LogKit.I("Init");
            RegisterModel(new MartialArtModel());
        }
    }
}