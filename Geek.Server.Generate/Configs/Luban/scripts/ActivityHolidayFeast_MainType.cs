
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
public sealed partial class ActivityHolidayFeast_MainType : Luban.BeanBase
{
    public ActivityHolidayFeast_MainType(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        EntryFunctionId = _buf.ReadInt();
        EntryRedPointName = _buf.ReadString();
        Feast_ViewName = _buf.ReadString();
        JumpType = _buf.ReadInt();
        PreView_Bg = _buf.ReadInt();
        PreView_Bg_Spine = _buf.ReadString();
        CVLangId = _buf.ReadString();
    }

    public static ActivityHolidayFeast_MainType DeserializeActivityHolidayFeast_MainType(ByteBuf _buf)
    {
        return new ActivityHolidayFeast_MainType(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 入口功能名Id
    /// </summary>
    public readonly int EntryFunctionId;
    /// <summary>
    /// 入口红点名
    /// </summary>
    public readonly string EntryRedPointName;
    /// <summary>
    /// 活动界面名
    /// </summary>
    public readonly string Feast_ViewName;
    /// <summary>
    /// 跳转枚举值
    /// </summary>
    public readonly int JumpType;
    /// <summary>
    /// 活动预览背景图
    /// </summary>
    public readonly int PreView_Bg;
    /// <summary>
    /// 活动预览背景图(spine)
    /// </summary>
    public readonly string PreView_Bg_Spine;
    /// <summary>
    /// 版权相关文本
    /// </summary>
    public readonly string CVLangId;
   
    public const int __ID__ = 205082264;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "EntryFunctionId:" + EntryFunctionId + ","
        + "EntryRedPointName:" + EntryRedPointName + ","
        + "Feast_ViewName:" + Feast_ViewName + ","
        + "JumpType:" + JumpType + ","
        + "PreView_Bg:" + PreView_Bg + ","
        + "PreView_Bg_Spine:" + PreView_Bg_Spine + ","
        + "CVLangId:" + CVLangId + ","
        + "}";
    }
}

}

