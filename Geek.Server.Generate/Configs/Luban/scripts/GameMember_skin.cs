
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
public sealed partial class GameMember_skin : Luban.BeanBase
{
    public GameMember_skin(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        skin = _buf.ReadString();
    }

    public static GameMember_skin DeserializeGameMember_skin(ByteBuf _buf)
    {
        return new GameMember_skin(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 皮肤名
    /// </summary>
    public readonly string skin;
   
    public const int __ID__ = -844354416;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "skin:" + skin + ","
        + "}";
    }
}

}

