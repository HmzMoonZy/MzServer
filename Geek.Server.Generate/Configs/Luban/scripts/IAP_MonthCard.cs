
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
public sealed partial class IAP_MonthCard : Luban.BeanBase
{
    public IAP_MonthCard(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        duration = _buf.ReadInt();
        alarmClock = _buf.ReadInt();
        postID = _buf.ReadString();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);products = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); products[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);productsPerDay = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); productsPerDay[__index0] = __e0;}}
        rebate = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);tips = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); tips[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);rewarTips = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); rewarTips[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);privilege = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); privilege[__index0] = __e0;}}
    }

    public static IAP_MonthCard DeserializeIAP_MonthCard(ByteBuf _buf)
    {
        return new IAP_MonthCard(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 持续时间<br/>（单位只能是天）
    /// </summary>
    public readonly int duration;
    /// <summary>
    /// 剩余时间到达这个点时，通过邮件给玩家发出续费提示<br/>（单位只能是天）
    /// </summary>
    public readonly int alarmClock;
    /// <summary>
    /// 续费提示邮件ID
    /// </summary>
    public readonly string postID;
    /// <summary>
    /// 当即奖励<br/>itemid,count|itemid,count
    /// </summary>
    public readonly string[] products;
    /// <summary>
    /// 每日奖励<br/>itemid,count|itemid,count
    /// </summary>
    public readonly string[] productsPerDay;
    /// <summary>
    /// 返利倍数<br/>（仅用于客户端展示）
    /// </summary>
    public readonly int rebate;
    /// <summary>
    /// 简短奖励提示多语言id组<br/>(最多配置3条）
    /// </summary>
    public readonly string[] tips;
    /// <summary>
    /// 完整奖励提示多语言id组
    /// </summary>
    public readonly string[] rewarTips;
    /// <summary>
    /// 特权
    /// </summary>
    public readonly string[] privilege;
   
    public const int __ID__ = 1344381001;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "duration:" + duration + ","
        + "alarmClock:" + alarmClock + ","
        + "postID:" + postID + ","
        + "products:" + Luban.StringUtil.CollectionToString(products) + ","
        + "productsPerDay:" + Luban.StringUtil.CollectionToString(productsPerDay) + ","
        + "rebate:" + rebate + ","
        + "tips:" + Luban.StringUtil.CollectionToString(tips) + ","
        + "rewarTips:" + Luban.StringUtil.CollectionToString(rewarTips) + ","
        + "privilege:" + Luban.StringUtil.CollectionToString(privilege) + ","
        + "}";
    }
}

}

