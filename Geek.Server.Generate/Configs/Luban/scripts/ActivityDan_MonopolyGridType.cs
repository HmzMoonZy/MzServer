
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace HotFix.Cfg
{
public sealed partial class ActivityDan_MonopolyGridType : Luban.BeanBase
{
    public ActivityDan_MonopolyGridType(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        iconAtlas = _buf.ReadInt();
        iconSprite = _buf.ReadString();
        qualityAtlas = _buf.ReadInt();
        qualitySprite = _buf.ReadString();
        tipTitleId = _buf.ReadString();
        tipDescId = _buf.ReadString();
    }

    public static ActivityDan_MonopolyGridType DeserializeActivityDan_MonopolyGridType(ByteBuf _buf)
    {
        return new ActivityDan_MonopolyGridType(_buf);
    }

    /// <summary>
    /// 格子类型<br/><br/>1.开始格子<br/><br/>2.奖励格子<br/>：无须配置<br/>3.分叉格子<br/><br/>4.火车开始格<br/><br/>5.魔法格子<br/><br/>6.监狱格子<br/><br/>7.累计奖励格子<br/><br/>8.子格子，仅参与拼接,无须配置<br/>9.游戏格子<br/>10.温泉格
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// icon图集Id<br/>2.奖励格子无须配置由道具决定<br/>8.拼接格子，无须配置
    /// </summary>
    public readonly int iconAtlas;
    /// <summary>
    /// icon图片名<br/>2.奖励格子无须配置由道具决定<br/>4.火车格子无须配置由主题风格决定<br/>8.拼接格子，无须配置<br/>
    /// </summary>
    public readonly string iconSprite;
    /// <summary>
    /// quality图集Id<br/>2.奖励格子无须配置由道具决定<br/>8.拼接格子，无须配置
    /// </summary>
    public readonly int qualityAtlas;
    /// <summary>
    /// 主题quality图片名<br/>2.奖励格子无须配置由道具决定<br/>8.拼接格子，无须配置
    /// </summary>
    public readonly string qualitySprite;
    /// <summary>
    /// 主题点击提示标题语言Id<br/>只需配置特定事件格
    /// </summary>
    public readonly string tipTitleId;
    /// <summary>
    /// 主题点击提示内容语言Id<br/>只需配置特定事件格
    /// </summary>
    public readonly string tipDescId;
   
    public const int __ID__ = 638820044;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "iconAtlas:" + iconAtlas + ","
        + "iconSprite:" + iconSprite + ","
        + "qualityAtlas:" + qualityAtlas + ","
        + "qualitySprite:" + qualitySprite + ","
        + "tipTitleId:" + tipTitleId + ","
        + "tipDescId:" + tipDescId + ","
        + "}";
    }
}

}

