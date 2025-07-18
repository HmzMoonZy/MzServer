
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
public sealed partial class GuildWar_WarTurntable : Luban.BeanBase
{
    public GuildWar_WarTurntable(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        costId = _buf.ReadInt();
        singleCost = _buf.ReadInt();
        pool = _buf.ReadInt();
    }

    public static GuildWar_WarTurntable DeserializeGuildWar_WarTurntable(ByteBuf _buf)
    {
        return new GuildWar_WarTurntable(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 消耗物品Id
    /// </summary>
    public readonly int costId;
    /// <summary>
    /// 单抽消耗<br/>物品数量
    /// </summary>
    public readonly int singleCost;
    /// <summary>
    /// 池子
    /// </summary>
    public readonly int pool;
   
    public const int __ID__ = 875106675;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "costId:" + costId + ","
        + "singleCost:" + singleCost + ","
        + "pool:" + pool + ","
        + "}";
    }
}

}

