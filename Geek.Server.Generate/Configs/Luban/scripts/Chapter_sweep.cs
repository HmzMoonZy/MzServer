
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
public sealed partial class Chapter_sweep : Luban.BeanBase
{
    public Chapter_sweep(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        range = _buf.ReadInt();
        multiplier = _buf.ReadInt();
    }

    public static Chapter_sweep DeserializeChapter_sweep(ByteBuf _buf)
    {
        return new Chapter_sweep(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 体力范围
    /// </summary>
    public readonly int range;
    /// <summary>
    /// 倍率
    /// </summary>
    public readonly int multiplier;
   
    public const int __ID__ = 960958554;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "range:" + range + ","
        + "multiplier:" + multiplier + ","
        + "}";
    }
}

}

