
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
public sealed partial class Mining_bonusGame : Luban.BeanBase
{
    public Mining_bonusGame(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        unlockLayer = _buf.ReadInt();
        itemid = _buf.ReadInt();
        num = _buf.ReadInt();
        showWeight = _buf.ReadInt();
        getRate = _buf.ReadInt();
    }

    public static Mining_bonusGame DeserializeMining_bonusGame(ByteBuf _buf)
    {
        return new Mining_bonusGame(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 解锁层数
    /// </summary>
    public readonly int unlockLayer;
    /// <summary>
    /// 道具id
    /// </summary>
    public readonly int itemid;
    /// <summary>
    /// 道具数量
    /// </summary>
    public readonly int num;
    /// <summary>
    /// 出现权重
    /// </summary>
    public readonly int showWeight;
    /// <summary>
    /// 获得概率（万分比）
    /// </summary>
    public readonly int getRate;
   
    public const int __ID__ = -933082206;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "unlockLayer:" + unlockLayer + ","
        + "itemid:" + itemid + ","
        + "num:" + num + ","
        + "showWeight:" + showWeight + ","
        + "getRate:" + getRate + ","
        + "}";
    }
}

}

