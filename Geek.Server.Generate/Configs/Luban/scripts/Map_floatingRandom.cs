
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
public sealed partial class Map_floatingRandom : Luban.BeanBase
{
    public Map_floatingRandom(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        count = _buf.ReadInt();
        minOffsetX = _buf.ReadFloat();
        maxOffsetX = _buf.ReadFloat();
        minOffsetY = _buf.ReadFloat();
        maxOffsetY = _buf.ReadFloat();
    }

    public static Map_floatingRandom DeserializeMap_floatingRandom(ByteBuf _buf)
    {
        return new Map_floatingRandom(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 随机数量
    /// </summary>
    public readonly int count;
    /// <summary>
    /// x轴最小随机范围
    /// </summary>
    public readonly float minOffsetX;
    /// <summary>
    /// x轴最大随机范围
    /// </summary>
    public readonly float maxOffsetX;
    /// <summary>
    /// y轴最小随机范围
    /// </summary>
    public readonly float minOffsetY;
    /// <summary>
    /// y轴最大随机范围
    /// </summary>
    public readonly float maxOffsetY;
   
    public const int __ID__ = 352509388;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "count:" + count + ","
        + "minOffsetX:" + minOffsetX + ","
        + "maxOffsetX:" + maxOffsetX + ","
        + "minOffsetY:" + minOffsetY + ","
        + "maxOffsetY:" + maxOffsetY + ","
        + "}";
    }
}

}

