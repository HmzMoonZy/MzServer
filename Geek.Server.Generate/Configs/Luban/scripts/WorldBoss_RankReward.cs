
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
public sealed partial class WorldBoss_RankReward : Luban.BeanBase
{
    public WorldBoss_RankReward(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        Tag = _buf.ReadInt();
        SubsectionID = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);RankRange = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); RankRange[__index0] = __e0;}}
        RoundMailId = _buf.ReadString();
        RoundMailIdTest = _buf.ReadString();
        RoundMailIdCN = _buf.ReadString();
        RoundMailIdTestCN = _buf.ReadString();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);RoundReward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); RoundReward[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);SeasonReward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); SeasonReward[__index0] = __e0;}}
        SeasionMailId = _buf.ReadString();
        SeasionMailIdTest = _buf.ReadString();
        SeasionMailIdCN = _buf.ReadString();
        SeasionMailIdTestCN = _buf.ReadString();
    }

    public static WorldBoss_RankReward DeserializeWorldBoss_RankReward(ByteBuf _buf)
    {
        return new WorldBoss_RankReward(_buf);
    }

    /// <summary>
    /// ID
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
    /// 正式服周邮件id
    /// </summary>
    public readonly string RoundMailId;
    /// <summary>
    /// 测试服周邮件id
    /// </summary>
    public readonly string RoundMailIdTest;
    /// <summary>
    /// 正式服周邮件id国内
    /// </summary>
    public readonly string RoundMailIdCN;
    /// <summary>
    /// 测试服周邮件id国内
    /// </summary>
    public readonly string RoundMailIdTestCN;
    /// <summary>
    /// 轮奖励
    /// </summary>
    public readonly string[] RoundReward;
    /// <summary>
    /// 结算奖励
    /// </summary>
    public readonly string[] SeasonReward;
    /// <summary>
    /// 正式服月结算邮件id
    /// </summary>
    public readonly string SeasionMailId;
    /// <summary>
    /// 测试服月结算邮件id
    /// </summary>
    public readonly string SeasionMailIdTest;
    /// <summary>
    /// 正式服月结算邮件id国内
    /// </summary>
    public readonly string SeasionMailIdCN;
    /// <summary>
    /// 测试服月结算邮件id国内
    /// </summary>
    public readonly string SeasionMailIdTestCN;
   
    public const int __ID__ = 1155739867;
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
        + "RoundMailId:" + RoundMailId + ","
        + "RoundMailIdTest:" + RoundMailIdTest + ","
        + "RoundMailIdCN:" + RoundMailIdCN + ","
        + "RoundMailIdTestCN:" + RoundMailIdTestCN + ","
        + "RoundReward:" + Luban.StringUtil.CollectionToString(RoundReward) + ","
        + "SeasonReward:" + Luban.StringUtil.CollectionToString(SeasonReward) + ","
        + "SeasionMailId:" + SeasionMailId + ","
        + "SeasionMailIdTest:" + SeasionMailIdTest + ","
        + "SeasionMailIdCN:" + SeasionMailIdCN + ","
        + "SeasionMailIdTestCN:" + SeasionMailIdTestCN + ","
        + "}";
    }
}

}

