
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
public sealed partial class ActivityHolidayFeast_SubType : Luban.BeanBase
{
    public ActivityHolidayFeast_SubType(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        EntryFunctionId = _buf.ReadInt();
        EntryNameId = _buf.ReadString();
        EntryRedPointName = _buf.ReadString();
        DataName = _buf.ReadString();
        ViewName = _buf.ReadString();
        GameplayEndTime = _buf.ReadInt();
        HideExchangeTime = _buf.ReadInt();
    }

    public static ActivityHolidayFeast_SubType DeserializeActivityHolidayFeast_SubType(ByteBuf _buf)
    {
        return new ActivityHolidayFeast_SubType(_buf);
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
    /// 入口名语言Id
    /// </summary>
    public readonly string EntryNameId;
    /// <summary>
    /// 入口红点名
    /// </summary>
    public readonly string EntryRedPointName;
    /// <summary>
    /// 数据模块名
    /// </summary>
    public readonly string DataName;
    /// <summary>
    /// UI模块名<br/>打开无参数
    /// </summary>
    public readonly string ViewName;
    /// <summary>
    /// 服务器结束时间-几天为结束
    /// </summary>
    public readonly int GameplayEndTime;
    /// <summary>
    /// 是否隐藏兑换时间
    /// </summary>
    public readonly int HideExchangeTime;
   
    public const int __ID__ = 909312757;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "EntryFunctionId:" + EntryFunctionId + ","
        + "EntryNameId:" + EntryNameId + ","
        + "EntryRedPointName:" + EntryRedPointName + ","
        + "DataName:" + DataName + ","
        + "ViewName:" + ViewName + ","
        + "GameplayEndTime:" + GameplayEndTime + ","
        + "HideExchangeTime:" + HideExchangeTime + ","
        + "}";
    }
}

}

