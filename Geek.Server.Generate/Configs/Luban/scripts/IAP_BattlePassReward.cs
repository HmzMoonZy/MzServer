
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
public sealed partial class IAP_BattlePassReward : Luban.BeanBase
{
    public IAP_BattlePassReward(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        level = _buf.ReadInt();
        groupId = _buf.ReadInt();
        type = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);freeReward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); freeReward[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);battlePassReward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); battlePassReward[__index0] = __e0;}}
        score = _buf.ReadInt();
    }

    public static IAP_BattlePassReward DeserializeIAP_BattlePassReward(ByteBuf _buf)
    {
        return new IAP_BattlePassReward(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 等级
    /// </summary>
    public readonly int level;
    /// <summary>
    /// 通行证组id
    /// </summary>
    public readonly int groupId;
    /// <summary>
    /// 奖励类型：<br/>1普通奖励<br/>2大奖<br/>3最终循环奖励
    /// </summary>
    public readonly int type;
    /// <summary>
    /// 免费奖励
    /// </summary>
    public readonly string[] freeReward;
    /// <summary>
    /// 通行证奖励
    /// </summary>
    public readonly string[] battlePassReward;
    /// <summary>
    /// 解锁点数：<br/>奖励类型为3时，该点数为循环点数
    /// </summary>
    public readonly int score;
   
    public const int __ID__ = -1023706945;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "level:" + level + ","
        + "groupId:" + groupId + ","
        + "type:" + type + ","
        + "freeReward:" + Luban.StringUtil.CollectionToString(freeReward) + ","
        + "battlePassReward:" + Luban.StringUtil.CollectionToString(battlePassReward) + ","
        + "score:" + score + ","
        + "}";
    }
}

}

