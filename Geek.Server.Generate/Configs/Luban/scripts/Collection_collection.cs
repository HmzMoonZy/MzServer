
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
public sealed partial class Collection_collection : Luban.BeanBase
{
    public Collection_collection(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        subType = _buf.ReadInt();
        rarity = _buf.ReadInt();
        suitId = _buf.ReadInt();
        tagId = _buf.ReadInt();
        needFragment = _buf.ReadInt();
        toFragment = _buf.ReadString();
        toFragmentOld = _buf.ReadString();
        nameId = _buf.ReadString();
        exNameId = _buf.ReadString();
        descId = _buf.ReadString();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);treasureDescId = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); treasureDescId[__index0] = __e0;}}
        pet = _buf.ReadInt();
        equipTagId = _buf.ReadInt();
        passiveType = _buf.ReadInt();
        passivePara = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);activationGet = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); activationGet[__index0] = __e0;}}
    }

    public static Collection_collection DeserializeCollection_collection(ByteBuf _buf)
    {
        return new Collection_collection(_buf);
    }

    /// <summary>
    /// 藏品ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 藏品类型<br/>0.普通藏品<br/>1.宠物至宝藏品<br/>2.装备至宝藏品
    /// </summary>
    public readonly int subType;
    /// <summary>
    /// 稀有度
    /// </summary>
    public readonly int rarity;
    /// <summary>
    /// 套装ID
    /// </summary>
    public readonly int suitId;
    /// <summary>
    /// 标签ID<br/>索引升星和被动
    /// </summary>
    public readonly int tagId;
    /// <summary>
    /// 合成碎片数量
    /// </summary>
    public readonly int needFragment;
    /// <summary>
    /// 同名转化碎片数量
    /// </summary>
    public readonly string toFragment;
    /// <summary>
    /// 同名转化碎片数量
    /// </summary>
    public readonly string toFragmentOld;
    /// <summary>
    /// 多语言名称
    /// </summary>
    public readonly string nameId;
    /// <summary>
    /// 藏品扩展名称<br/>装备名称
    /// </summary>
    public readonly string exNameId;
    /// <summary>
    /// 多语言描述
    /// </summary>
    public readonly string descId;
    /// <summary>
    /// 至宝藏品描述
    /// </summary>
    public readonly string[] treasureDescId;
    /// <summary>
    /// 宠物藏品对应的宠物ID
    /// </summary>
    public readonly int pet;
    /// <summary>
    /// 装备藏品对应装备TagId
    /// </summary>
    public readonly int equipTagId;
    /// <summary>
    /// 被动生效条件1 无条件<br/>2 每消耗X金币<br/>3 竞技场获胜1次<br/>4 遇到奇遇 5 遇到大吉<br/>6 遇到小吉 7 击败精英怪<br/>8 翻牌高收益<br/>9 在排行榜活动中获得前3名<br/>10 获得紫色品质装备<br/>11 获得橙色品质装备<br/>12 进行游历次数<br/>13 宠物升星<br/>14 通过挑战之塔1层<br/>15 消耗洗练石数量<br/>16 SSS属性获得次数<br/>17 消耗哥布林矿工数<br/>18挖矿到第X层<br/>19获得天使技能X次<br/>20 获得恶魔技能X次<br/>21在冒险中获得的金币数<br/>22黑市购买次数<br/>23 公会BOSS参与次数<br/>24 宠物升级次数
    /// </summary>
    public readonly int passiveType;
    /// <summary>
    /// 被动效果参数
    /// </summary>
    public readonly int passivePara;
    /// <summary>
    /// 激活藏品获取<br/>道具id,数量
    /// </summary>
    public readonly string[] activationGet;
   
    public const int __ID__ = 1756034751;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "subType:" + subType + ","
        + "rarity:" + rarity + ","
        + "suitId:" + suitId + ","
        + "tagId:" + tagId + ","
        + "needFragment:" + needFragment + ","
        + "toFragment:" + toFragment + ","
        + "toFragmentOld:" + toFragmentOld + ","
        + "nameId:" + nameId + ","
        + "exNameId:" + exNameId + ","
        + "descId:" + descId + ","
        + "treasureDescId:" + Luban.StringUtil.CollectionToString(treasureDescId) + ","
        + "pet:" + pet + ","
        + "equipTagId:" + equipTagId + ","
        + "passiveType:" + passiveType + ","
        + "passivePara:" + passivePara + ","
        + "activationGet:" + Luban.StringUtil.CollectionToString(activationGet) + ","
        + "}";
    }
}

}

