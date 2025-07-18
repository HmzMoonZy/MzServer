
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
public sealed partial class Equip_updateLevel : Luban.BeanBase
{
    public Equip_updateLevel(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        level = _buf.ReadInt();
        nextID = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);levelupCost = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); levelupCost[__index0] = __e0;}}
    }

    public static Equip_updateLevel DeserializeEquip_updateLevel(ByteBuf _buf)
    {
        return new Equip_updateLevel(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 等级
    /// </summary>
    public readonly int level;
    /// <summary>
    /// 下一等级ID 满级为0
    /// </summary>
    public readonly int nextID;
    /// <summary>
    /// 升至下一级的消耗
    /// </summary>
    public readonly string[] levelupCost;
   
    public const int __ID__ = 359253644;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "level:" + level + ","
        + "nextID:" + nextID + ","
        + "levelupCost:" + Luban.StringUtil.CollectionToString(levelupCost) + ","
        + "}";
    }
}

}

