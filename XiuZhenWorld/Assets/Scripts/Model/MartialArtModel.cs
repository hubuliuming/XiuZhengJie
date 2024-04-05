/****************************************************
    文件：MartialArtModel.cs
    作者：Y
    邮箱: 916111418@qq.com
    日期：#CreateTime#
    功能：Nothing
*****************************************************/

using System.Collections.Generic;
using UnityEngine;
using QFramework;

public class MartialArtModel : AbstractModel
{
    public Dictionary<int, AcupunctureData[]> columAritDic;
    // public AcupunctureData[] columArtDatas;
    // public AcupunctureData[] colum1ArtDatas;
    // public AcupunctureData[] colum2ArtDatas;
    // public AcupunctureData[] colum3ArtDatas;
    // public AcupunctureData[] colum4ArtDatas;
    // public AcupunctureData[] colum5ArtDatas;
    // public AcupunctureData[] colum6ArtDatas;
    protected override void OnInit()
    {
        Debug.Log("创造功法初始化");

        columAritDic = new Dictionary<int, AcupunctureData[]>();
        var columArtDatas = new AcupunctureData[8];
        columArtDatas[0].Name = "胞中";
        columArtDatas[1].Name = "神阙";
        columArtDatas[2].Name = "巨阙";
        columArtDatas[3].Name = "膻中";
        columArtDatas[4].Name = "璇玑";
        columArtDatas[5].Name = "会阴";
        columArtDatas[6].Name = "天突";
        columArtDatas[7].Name = "廉泉";
        columAritDic.Add(0,columArtDatas);

        var colum1ArtDatas = new AcupunctureData[9];
        colum1ArtDatas[0].Name = "阴都";
        colum1ArtDatas[1].Name = "横骨";
        colum1ArtDatas[2].Name = "期门";
        colum1ArtDatas[3].Name = "腹哀";
        colum1ArtDatas[4].Name = "大横";
        colum1ArtDatas[5].Name = "风市";
        colum1ArtDatas[6].Name = "冲门";
        colum1ArtDatas[7].Name = "筑宾";
        colum1ArtDatas[8].Name = "带脉";
        columAritDic.Add(1,colum1ArtDatas);
        
        var colum2ArtDatas = new AcupunctureData[8];
        colum2ArtDatas[0].Name = "通谷";
        colum2ArtDatas[1].Name = "长强";
        colum2ArtDatas[2].Name = "阳关";
        colum2ArtDatas[3].Name = "命门";
        colum2ArtDatas[4].Name = "脊中";
        colum2ArtDatas[5].Name = "至阳";
        colum2ArtDatas[6].Name = "大椎";
        colum2ArtDatas[7].Name = "哑门";
        columAritDic.Add(2,colum2ArtDatas);
        
        var colum3ArtDatas = new AcupunctureData[9];
        colum3ArtDatas[0].Name = "幽门";
        colum3ArtDatas[1].Name = "风池";
        colum3ArtDatas[2].Name = "承灵";
        colum3ArtDatas[3].Name = "气冲";
        colum3ArtDatas[4].Name = "金门";
        colum3ArtDatas[5].Name = "阳交";
        colum3ArtDatas[6].Name = "需俞";
        colum3ArtDatas[7].Name = "府井";
        colum3ArtDatas[8].Name = "百会";
        columAritDic.Add(3,colum3ArtDatas);
        
        var colum4ArtDatas = new AcupunctureData[8];
        colum4ArtDatas[0].Name = "曲骨";
        colum4ArtDatas[1].Name = "乳根";
        colum4ArtDatas[2].Name = "阴谷";
        colum4ArtDatas[3].Name = "气穴";
        colum4ArtDatas[4].Name = "交信";
        colum4ArtDatas[5].Name = "照海";
        colum4ArtDatas[6].Name = "然谷";
        colum4ArtDatas[7].Name = "龈交";
        columAritDic.Add(4,colum4ArtDatas);
        
        var colum5ArtDatas = new AcupunctureData[9];
        colum5ArtDatas[0].Name = "关元";
        colum5ArtDatas[1].Name = "盆缺";
        colum5ArtDatas[2].Name = "晴明";
        colum5ArtDatas[3].Name = "仆参";
        colum5ArtDatas[4].Name = "居勠";
        colum5ArtDatas[5].Name = "四满";
        colum5ArtDatas[6].Name = "地仓";
        colum5ArtDatas[7].Name = "承泣";
        colum5ArtDatas[8].Name = "商曲";
        columAritDic.Add(5,colum5ArtDatas);
        
        var colum6ArtDatas = new AcupunctureData[8];
        colum6ArtDatas[0].Name = "气海";
        colum6ArtDatas[1].Name = "人迎";
        colum6ArtDatas[2].Name = "申脉";
        colum6ArtDatas[3].Name = "肩愚";
        colum6ArtDatas[4].Name = "巨骨";
        colum6ArtDatas[5].Name = "天勠";
        colum6ArtDatas[6].Name = "巨勠";
        colum6ArtDatas[7].Name = "阴交";
        columAritDic.Add(6,colum6ArtDatas);
    }
}
//穴位数据
public struct AcupunctureData
{
    public string Name;
}