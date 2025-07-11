
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
public sealed partial class FestivalTurntable_FestivalTurntablePay : Luban.BeanBase
{
    public FestivalTurntable_FestivalTurntablePay(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        GroupId = _buf.ReadInt();
        PurchaseId = _buf.ReadInt();
        AdId = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Price = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); Price[__index0] = __e0;}}
        ObjName = _buf.ReadString();
        objToplimit = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);ObjGoods = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); ObjGoods[__index0] = __e0;}}
    }

    public static FestivalTurntable_FestivalTurntablePay DeserializeFestivalTurntable_FestivalTurntablePay(ByteBuf _buf)
    {
        return new FestivalTurntable_FestivalTurntablePay(_buf);
    }

    /// <summary>
    /// 编号
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 礼包组<br/>
    /// </summary>
    public readonly int GroupId;
    /// <summary>
    /// 支付ID<br/>不配则直接领取
    /// </summary>
    public readonly int PurchaseId;
    /// <summary>
    /// 广告ID
    /// </summary>
    public readonly int AdId;
    /// <summary>
    /// 宝石购买
    /// </summary>
    public readonly string[] Price;
    /// <summary>
    /// 目标名称（多语言）
    /// </summary>
    public readonly string ObjName;
    /// <summary>
    /// 限购数量
    /// </summary>
    public readonly int objToplimit;
    /// <summary>
    /// 出售道具
    /// </summary>
    public readonly string[] ObjGoods;
   
    public const int __ID__ = 1863691509;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "GroupId:" + GroupId + ","
        + "PurchaseId:" + PurchaseId + ","
        + "AdId:" + AdId + ","
        + "Price:" + Luban.StringUtil.CollectionToString(Price) + ","
        + "ObjName:" + ObjName + ","
        + "objToplimit:" + objToplimit + ","
        + "ObjGoods:" + Luban.StringUtil.CollectionToString(ObjGoods) + ","
        + "}";
    }
}

}

