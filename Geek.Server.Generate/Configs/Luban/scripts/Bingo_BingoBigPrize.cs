
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
public sealed partial class Bingo_BingoBigPrize : Luban.BeanBase
{
    public Bingo_BingoBigPrize(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        RewardCount = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Point = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); Point[__index0] = __e0;}}
        PointLast = _buf.ReadInt();
    }

    public static Bingo_BingoBigPrize DeserializeBingo_BingoBigPrize(ByteBuf _buf)
    {
        return new Bingo_BingoBigPrize(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// 大奖数量
    /// </summary>
    public readonly int RewardCount;
    /// <summary>
    /// 能开出的点，乱序
    /// </summary>
    public readonly int[] Point;
    /// <summary>
    /// 最后一个开出的点
    /// </summary>
    public readonly int PointLast;
   
    public const int __ID__ = 970932209;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "RewardCount:" + RewardCount + ","
        + "Point:" + Luban.StringUtil.CollectionToString(Point) + ","
        + "PointLast:" + PointLast + ","
        + "}";
    }
}

}

