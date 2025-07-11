
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
public sealed partial class MainLevelReward_MainLevelChest : Luban.BeanBase
{
    public MainLevelReward_MainLevelChest(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        level = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Reward = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); Reward[__index0] = __e0;}}
    }

    public static MainLevelReward_MainLevelChest DeserializeMainLevelReward_MainLevelChest(ByteBuf _buf)
    {
        return new MainLevelReward_MainLevelChest(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 关卡层数
    /// </summary>
    public readonly int level;
    /// <summary>
    /// 阶段奖励
    /// </summary>
    public readonly int[] Reward;
   
    public const int __ID__ = -108897477;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "level:" + level + ","
        + "Reward:" + Luban.StringUtil.CollectionToString(Reward) + ","
        + "}";
    }
}

}

