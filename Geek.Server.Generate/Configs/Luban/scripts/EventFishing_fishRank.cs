
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
public sealed partial class EventFishing_fishRank : Luban.BeanBase
{
    public EventFishing_fishRank(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        WeightMax = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);RankReward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); RankReward[__index0] = __e0;}}
    }

    public static EventFishing_fishRank DeserializeEventFishing_fishRank(ByteBuf _buf)
    {
        return new EventFishing_fishRank(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 重量最大值
    /// </summary>
    public readonly int WeightMax;
    /// <summary>
    /// 排行榜奖励<br/>最高名次，最低名次，奖励|
    /// </summary>
    public readonly string[] RankReward;
   
    public const int __ID__ = -2016942253;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "WeightMax:" + WeightMax + ","
        + "RankReward:" + Luban.StringUtil.CollectionToString(RankReward) + ","
        + "}";
    }
}

}

