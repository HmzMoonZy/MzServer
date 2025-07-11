
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
public sealed partial class IAP_PushPacks : Luban.BeanBase
{
    public IAP_PushPacks(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        packType = _buf.ReadInt();
        group = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);products = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); products[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);products2 = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); products2[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);products3 = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); products3[__index0] = __e0;}}
        priority = _buf.ReadInt();
        parameters = _buf.ReadString();
        nameID = _buf.ReadString();
        descID = _buf.ReadString();
        valueNum = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);valueDescID = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); valueDescID[__index0] = __e0;}}
        iconAtlasID = _buf.ReadInt();
        iconName = _buf.ReadString();
        isEffect = _buf.ReadInt();
        nodePrefab = _buf.ReadString();
    }

    public static IAP_PushPacks DeserializeIAP_PushPacks(ByteBuf _buf)
    {
        return new IAP_PushPacks(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 触发方式<br/><br/>1、首充礼包(1次，充值任意金额可领取)<br/>2、开服礼包(1次)<br/>3、限时礼包(可重复购买)<br/>4、章节礼包(只显示一个，可填写多个)<br/>5、推送礼包(只显示一个，可填写多个)<br/>6、充值礼包（购买领取，购买完一个出下一个）<br/>7、见面礼
    /// </summary>
    public readonly int packType;
    /// <summary>
    /// 组<br/>（完成一个显示下一个）
    /// </summary>
    public readonly int group;
    /// <summary>
    /// 当即奖励<br/>itemid,count,showCount|itemid,count,,showCount
    /// </summary>
    public readonly string[] products;
    /// <summary>
    /// 第二天奖励
    /// </summary>
    public readonly string[] products2;
    /// <summary>
    /// 第三天奖励
    /// </summary>
    public readonly string[] products3;
    /// <summary>
    /// 优先级<br/>1最优先
    /// </summary>
    public readonly int priority;
    /// <summary>
    /// 参数<br/>
    /// </summary>
    public readonly string parameters;
    /// <summary>
    /// 名称
    /// </summary>
    public readonly string nameID;
    /// <summary>
    /// 描述
    /// </summary>
    public readonly string descID;
    /// <summary>
    /// 返利
    /// </summary>
    public readonly int valueNum;
    /// <summary>
    /// 价值描述
    /// </summary>
    public readonly string[] valueDescID;
    /// <summary>
    /// icon图集
    /// </summary>
    public readonly int iconAtlasID;
    /// <summary>
    /// icon名称
    /// </summary>
    public readonly string iconName;
    /// <summary>
    /// 是否显示特效
    /// </summary>
    public readonly int isEffect;
    /// <summary>
    /// 使用的预制体
    /// </summary>
    public readonly string nodePrefab;
   
    public const int __ID__ = 1861644569;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "packType:" + packType + ","
        + "group:" + group + ","
        + "products:" + Luban.StringUtil.CollectionToString(products) + ","
        + "products2:" + Luban.StringUtil.CollectionToString(products2) + ","
        + "products3:" + Luban.StringUtil.CollectionToString(products3) + ","
        + "priority:" + priority + ","
        + "parameters:" + parameters + ","
        + "nameID:" + nameID + ","
        + "descID:" + descID + ","
        + "valueNum:" + valueNum + ","
        + "valueDescID:" + Luban.StringUtil.CollectionToString(valueDescID) + ","
        + "iconAtlasID:" + iconAtlasID + ","
        + "iconName:" + iconName + ","
        + "isEffect:" + isEffect + ","
        + "nodePrefab:" + nodePrefab + ","
        + "}";
    }
}

}

