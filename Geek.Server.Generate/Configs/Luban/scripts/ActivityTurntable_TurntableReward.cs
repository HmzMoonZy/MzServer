
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
public sealed partial class ActivityTurntable_TurntableReward : Luban.BeanBase
{
    public ActivityTurntable_TurntableReward(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        rewardID = _buf.ReadInt();
        point = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);reward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); reward[__index0] = __e0;}}
    }

    public static ActivityTurntable_TurntableReward DeserializeActivityTurntable_TurntableReward(ByteBuf _buf)
    {
        return new ActivityTurntable_TurntableReward(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 次数奖励IID
    /// </summary>
    public readonly int rewardID;
    /// <summary>
    /// 积分
    /// </summary>
    public readonly int point;
    /// <summary>
    /// 奖励
    /// </summary>
    public readonly string[] reward;
   
    public const int __ID__ = 1587666083;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "rewardID:" + rewardID + ","
        + "point:" + point + ","
        + "reward:" + Luban.StringUtil.CollectionToString(reward) + ","
        + "}";
    }
}

}

