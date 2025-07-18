
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
public sealed partial class CrossArena_CrossArenaChallengeListRule : Luban.BeanBase
{
    public CrossArena_CrossArenaChallengeListRule(ByteBuf _buf) 
    {
        ID = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);Rank = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); Rank[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);pos1 = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); pos1[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);pos2 = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); pos2[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);pos3 = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); pos3[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);pos5 = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); pos5[__index0] = __e0;}}
    }

    public static CrossArena_CrossArenaChallengeListRule DeserializeCrossArena_CrossArenaChallengeListRule(ByteBuf _buf)
    {
        return new CrossArena_CrossArenaChallengeListRule(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int ID;
    /// <summary>
    /// 排名区间<br/>
    /// </summary>
    public readonly int[] Rank;
    /// <summary>
    /// 位置1随机区间<br/>当前排名*系数1，当前排名*系数2
    /// </summary>
    public readonly float[] pos1;
    /// <summary>
    /// 位置2随机区间<br/>当前排名*系数1，当前排名*系数2
    /// </summary>
    public readonly float[] pos2;
    /// <summary>
    /// 位置3随机区间<br/>当前排名*系数1，当前排名*系数2
    /// </summary>
    public readonly float[] pos3;
    /// <summary>
    /// 位置5随机区间<br/>当前排名+系数1，当前排名+系数2
    /// </summary>
    public readonly float[] pos5;
   
    public const int __ID__ = -192533314;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "ID:" + ID + ","
        + "Rank:" + Luban.StringUtil.CollectionToString(Rank) + ","
        + "pos1:" + Luban.StringUtil.CollectionToString(pos1) + ","
        + "pos2:" + Luban.StringUtil.CollectionToString(pos2) + ","
        + "pos3:" + Luban.StringUtil.CollectionToString(pos3) + ","
        + "pos5:" + Luban.StringUtil.CollectionToString(pos5) + ","
        + "}";
    }
}

}

