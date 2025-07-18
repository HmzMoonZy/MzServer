
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
public sealed partial class TalentApex_talentApexEffect : Luban.BeanBase
{
    public TalentApex_talentApexEffect(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        level = _buf.ReadInt();
        tagID = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);levelupCost = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); levelupCost[__index0] = __e0;}}
        effectType = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);skills = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); skills[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);attributes = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); attributes[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);power = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); power[__index0] = __e0;}}
    }

    public static TalentApex_talentApexEffect DeserializeTalentApex_talentApexEffect(ByteBuf _buf)
    {
        return new TalentApex_talentApexEffect(_buf);
    }

    /// <summary>
    /// 进化ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 等级
    /// </summary>
    public readonly int level;
    /// <summary>
    /// 天赋标签
    /// </summary>
    public readonly int tagID;
    /// <summary>
    /// 升级消耗
    /// </summary>
    public readonly string[] levelupCost;
    /// <summary>
    /// 改变宠物的效果类型<br/>1升级肉鸽技能<br/>2获得新肉鸽技能
    /// </summary>
    public readonly int effectType;
    /// <summary>
    /// 改变技能
    /// </summary>
    public readonly int[] skills;
    /// <summary>
    /// 获得属性
    /// </summary>
    public readonly string[] attributes;
    /// <summary>
    /// 层数2万分比战力<br/>层数3万分比战力<br/>（拥有增加战力）
    /// </summary>
    public readonly int[] power;
   
    public const int __ID__ = -579258576;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "level:" + level + ","
        + "tagID:" + tagID + ","
        + "levelupCost:" + Luban.StringUtil.CollectionToString(levelupCost) + ","
        + "effectType:" + effectType + ","
        + "skills:" + Luban.StringUtil.CollectionToString(skills) + ","
        + "attributes:" + Luban.StringUtil.CollectionToString(attributes) + ","
        + "power:" + Luban.StringUtil.CollectionToString(power) + ","
        + "}";
    }
}

}

