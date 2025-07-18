
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
public sealed partial class Shop_PigBank : Luban.BeanBase
{
    public Shop_PigBank(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        ActivityId = _buf.ReadInt();
        Type = _buf.ReadInt();
        ShopId = _buf.ReadInt();
        BaseValue = _buf.ReadInt();
        InitValue = _buf.ReadInt();
        MaxValue = _buf.ReadInt();
        LayerAdd = _buf.ReadInt();
        TimeLimit = _buf.ReadInt();
        TitleId = _buf.ReadString();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);DescId = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); DescId[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);ResId = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); ResId[__index0] = __e0;}}
    }

    public static Shop_PigBank DeserializeShop_PigBank(ByteBuf _buf)
    {
        return new Shop_PigBank(_buf);
    }

    /// <summary>
    /// 档位ID
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// 活动表ActivityDan-&gt;ID<br/>(0:新号初始活动)
    /// </summary>
    public readonly int ActivityId;
    /// <summary>
    /// 储钱罐类型<br/>1.单次出现<br/>2.重复出现（活动期间）
    /// </summary>
    public readonly int Type;
    /// <summary>
    /// IAP的purchase的ID
    /// </summary>
    public readonly int ShopId;
    /// <summary>
    /// 价值倍率展示
    /// </summary>
    public readonly int BaseValue;
    /// <summary>
    /// 初始奖励
    /// </summary>
    public readonly int InitValue;
    /// <summary>
    /// 最高奖励
    /// </summary>
    public readonly int MaxValue;
    /// <summary>
    /// 每消耗1点体力增长多少钻石额度
    /// </summary>
    public readonly int LayerAdd;
    /// <summary>
    /// 限时(小时)
    /// </summary>
    public readonly int TimeLimit;
    /// <summary>
    /// 标题多语言ID
    /// </summary>
    public readonly string TitleId;
    /// <summary>
    /// 各个描述多语言ID<br/>金猪描述|金猪升级描述|金猪解锁描述|金猪满描述
    /// </summary>
    public readonly string[] DescId;
    /// <summary>
    /// 金猪对应资源ID<br/>主界面icon|活动面板图标
    /// </summary>
    public readonly string[] ResId;
   
    public const int __ID__ = -1832661855;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "ActivityId:" + ActivityId + ","
        + "Type:" + Type + ","
        + "ShopId:" + ShopId + ","
        + "BaseValue:" + BaseValue + ","
        + "InitValue:" + InitValue + ","
        + "MaxValue:" + MaxValue + ","
        + "LayerAdd:" + LayerAdd + ","
        + "TimeLimit:" + TimeLimit + ","
        + "TitleId:" + TitleId + ","
        + "DescId:" + Luban.StringUtil.CollectionToString(DescId) + ","
        + "ResId:" + Luban.StringUtil.CollectionToString(ResId) + ","
        + "}";
    }
}

}

