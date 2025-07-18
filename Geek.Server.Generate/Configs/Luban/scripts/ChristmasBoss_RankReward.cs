
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
public sealed partial class ChristmasBoss_RankReward : Luban.BeanBase
{
    public ChristmasBoss_RankReward(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        Tag = _buf.ReadInt();
        SubsectionID = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);RankRange = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); RankRange[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);SeasonReward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); SeasonReward[__index0] = __e0;}}
        SeasionMailId = _buf.ReadString();
        SeasionMailIdCN = _buf.ReadString();
    }

    public static ChristmasBoss_RankReward DeserializeChristmasBoss_RankReward(ByteBuf _buf)
    {
        return new ChristmasBoss_RankReward(_buf);
    }

    /// <summary>
    /// ID<br/>Tag*100000+id
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// 第几期
    /// </summary>
    public readonly int Tag;
    /// <summary>
    /// 所属段位
    /// </summary>
    public readonly int SubsectionID;
    /// <summary>
    /// 排名区间
    /// </summary>
    public readonly int[] RankRange;
    /// <summary>
    /// 结算奖励
    /// </summary>
    public readonly string[] SeasonReward;
    /// <summary>
    /// 圣诞活动结算奖励
    /// </summary>
    public readonly string SeasionMailId;
    /// <summary>
    /// 圣诞活动结算奖励CN
    /// </summary>
    public readonly string SeasionMailIdCN;
   
    public const int __ID__ = -1289155861;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "Tag:" + Tag + ","
        + "SubsectionID:" + SubsectionID + ","
        + "RankRange:" + Luban.StringUtil.CollectionToString(RankRange) + ","
        + "SeasonReward:" + Luban.StringUtil.CollectionToString(SeasonReward) + ","
        + "SeasionMailId:" + SeasionMailId + ","
        + "SeasionMailIdCN:" + SeasionMailIdCN + ","
        + "}";
    }
}

}

