
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
public sealed partial class ArtEffect_UIEffect : Luban.BeanBase
{
    public ArtEffect_UIEffect(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        path = _buf.ReadString();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);offsetPos = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); offsetPos[__index0] = __e0;}}
    }

    public static ArtEffect_UIEffect DeserializeArtEffect_UIEffect(ByteBuf _buf)
    {
        return new ArtEffect_UIEffect(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// prefab路径
    /// </summary>
    public readonly string path;
    /// <summary>
    /// 坐标偏移值
    /// </summary>
    public readonly int[] offsetPos;
   
    public const int __ID__ = -1398234256;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "path:" + path + ","
        + "offsetPos:" + Luban.StringUtil.CollectionToString(offsetPos) + ","
        + "}";
    }
}

}

