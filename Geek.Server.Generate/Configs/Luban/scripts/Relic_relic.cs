
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
public sealed partial class Relic_relic : Luban.BeanBase
{
    public Relic_relic(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        NameId = _buf.ReadString();
        DescId = _buf.ReadString();
        type = _buf.ReadInt();
        bgAtlasID = _buf.ReadInt();
        bgName = _buf.ReadString();
        baseName = _buf.ReadString();
        iconAtlasID = _buf.ReadInt();
        iconName = _buf.ReadString();
        unlockCostID = _buf.ReadInt();
        unlockCostNumber = _buf.ReadInt();
        star = _buf.ReadInt();
        starUpType = _buf.ReadInt();
        AttributesType = _buf.ReadInt();
    }

    public static Relic_relic DeserializeRelic_relic(ByteBuf _buf)
    {
        return new Relic_relic(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 名称多语言ID
    /// </summary>
    public readonly string NameId;
    /// <summary>
    /// 描述多语言ID
    /// </summary>
    public readonly string DescId;
    /// <summary>
    /// 类型<br/>1、普通<br/>2、特殊
    /// </summary>
    public readonly int type;
    /// <summary>
    /// bg图集id
    /// </summary>
    public readonly int bgAtlasID;
    /// <summary>
    /// bg名称
    /// </summary>
    public readonly string bgName;
    /// <summary>
    /// base名称
    /// </summary>
    public readonly string baseName;
    /// <summary>
    /// icon图集id
    /// </summary>
    public readonly int iconAtlasID;
    /// <summary>
    /// icon名称
    /// </summary>
    public readonly string iconName;
    /// <summary>
    /// 解锁及升星消耗的碎片ID
    /// </summary>
    public readonly int unlockCostID;
    /// <summary>
    /// 解锁消耗的碎片数量
    /// </summary>
    public readonly int unlockCostNumber;
    /// <summary>
    /// 最大星级
    /// </summary>
    public readonly int star;
    /// <summary>
    /// 升星属性<br/>从starUp表里读
    /// </summary>
    public readonly int starUpType;
    /// <summary>
    /// 基础属性<br/>从updateLevel里读
    /// </summary>
    public readonly int AttributesType;
   
    public const int __ID__ = 1477472135;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "NameId:" + NameId + ","
        + "DescId:" + DescId + ","
        + "type:" + type + ","
        + "bgAtlasID:" + bgAtlasID + ","
        + "bgName:" + bgName + ","
        + "baseName:" + baseName + ","
        + "iconAtlasID:" + iconAtlasID + ","
        + "iconName:" + iconName + ","
        + "unlockCostID:" + unlockCostID + ","
        + "unlockCostNumber:" + unlockCostNumber + ","
        + "star:" + star + ","
        + "starUpType:" + starUpType + ","
        + "AttributesType:" + AttributesType + ","
        + "}";
    }
}

}

