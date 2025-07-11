
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
public sealed partial class EventDive_DiveDynamic : Luban.BeanBase
{
    public EventDive_DiveDynamic(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);ComsumRange = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); ComsumRange[__index0] = __e0;}}
        MinDepth = _buf.ReadInt();
        MaxDepth = _buf.ReadInt();
        MinItem = _buf.ReadInt();
        MaxItem = _buf.ReadInt();
    }

    public static EventDive_DiveDynamic DeserializeEventDive_DiveDynamic(ByteBuf _buf)
    {
        return new EventDive_DiveDynamic(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// 累计消耗水母范围
    /// </summary>
    public readonly int[] ComsumRange;
    /// <summary>
    /// 最小深度
    /// </summary>
    public readonly int MinDepth;
    /// <summary>
    /// 最大深度
    /// </summary>
    public readonly int MaxDepth;
    /// <summary>
    /// 最小奖励
    /// </summary>
    public readonly int MinItem;
    /// <summary>
    /// 最大奖励
    /// </summary>
    public readonly int MaxItem;
   
    public const int __ID__ = 476604506;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "ComsumRange:" + Luban.StringUtil.CollectionToString(ComsumRange) + ","
        + "MinDepth:" + MinDepth + ","
        + "MaxDepth:" + MaxDepth + ","
        + "MinItem:" + MinItem + ","
        + "MaxItem:" + MaxItem + ","
        + "}";
    }
}

}

