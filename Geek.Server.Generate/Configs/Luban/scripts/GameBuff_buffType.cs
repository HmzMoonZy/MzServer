
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
public sealed partial class GameBuff_buffType : Luban.BeanBase
{
    public GameBuff_buffType(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        sClassName = _buf.ReadString();
        cClassName = _buf.ReadString();
    }

    public static GameBuff_buffType DeserializeGameBuff_buffType(ByteBuf _buf)
    {
        return new GameBuff_buffType(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 技能class
    /// </summary>
    public readonly string sClassName;
    /// <summary>
    /// 技能class
    /// </summary>
    public readonly string cClassName;
   
    public const int __ID__ = -1957814873;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "sClassName:" + sClassName + ","
        + "cClassName:" + cClassName + ","
        + "}";
    }
}

}

