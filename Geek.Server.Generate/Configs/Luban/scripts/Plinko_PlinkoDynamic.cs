
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
public sealed partial class Plinko_PlinkoDynamic : Luban.BeanBase
{
    public Plinko_PlinkoDynamic(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);ComsumRange = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); ComsumRange[__index0] = __e0;}}
        MinValue = _buf.ReadInt();
        MaxValue = _buf.ReadInt();
    }

    public static Plinko_PlinkoDynamic DeserializePlinko_PlinkoDynamic(ByteBuf _buf)
    {
        return new Plinko_PlinkoDynamic(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// 累计消耗任务道具范围
    /// </summary>
    public readonly int[] ComsumRange;
    /// <summary>
    /// 获得最小价值
    /// </summary>
    public readonly int MinValue;
    /// <summary>
    /// 获得最大价值
    /// </summary>
    public readonly int MaxValue;
   
    public const int __ID__ = 889883072;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "ComsumRange:" + Luban.StringUtil.CollectionToString(ComsumRange) + ","
        + "MinValue:" + MinValue + ","
        + "MaxValue:" + MaxValue + ","
        + "}";
    }
}

}

