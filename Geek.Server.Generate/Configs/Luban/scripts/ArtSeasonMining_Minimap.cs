
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
public sealed partial class ArtSeasonMining_Minimap : Luban.BeanBase
{
    public ArtSeasonMining_Minimap(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        path = _buf.ReadString();
    }

    public static ArtSeasonMining_Minimap DeserializeArtSeasonMining_Minimap(ByteBuf _buf)
    {
        return new ArtSeasonMining_Minimap(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// Prefab 路径
    /// </summary>
    public readonly string path;
   
    public const int __ID__ = -987080388;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "path:" + path + ","
        + "}";
    }
}

}

