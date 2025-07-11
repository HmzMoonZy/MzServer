
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
public sealed partial class Guild_guildGiftLevel : Luban.BeanBase
{
    public Guild_guildGiftLevel(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        NeedExp = _buf.ReadInt();
        NeedKey = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Reward = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); Reward[__index0] = __e0;}}
    }

    public static Guild_guildGiftLevel DeserializeGuild_guildGiftLevel(ByteBuf _buf)
    {
        return new Guild_guildGiftLevel(_buf);
    }

    /// <summary>
    /// 等级
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// 升级所需经验
    /// </summary>
    public readonly int NeedExp;
    /// <summary>
    /// 大宝藏所需钥匙数
    /// </summary>
    public readonly int NeedKey;
    /// <summary>
    /// 大宝箱奖励
    /// </summary>
    public readonly string[] Reward;
   
    public const int __ID__ = 959498093;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "NeedExp:" + NeedExp + ","
        + "NeedKey:" + NeedKey + ","
        + "Reward:" + Luban.StringUtil.CollectionToString(Reward) + ","
        + "}";
    }
}

}

