
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
public sealed partial class TowerChallenge_TowerUI : Luban.BeanBase
{
    public TowerChallenge_TowerUI(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        normalBg = _buf.ReadString();
        bossBg = _buf.ReadString();
        topBg = _buf.ReadString();
        sky = _buf.ReadString();
        moveCloud = _buf.ReadString();
        staticCloud = _buf.ReadString();
    }

    public static TowerChallenge_TowerUI DeserializeTowerChallenge_TowerUI(ByteBuf _buf)
    {
        return new TowerChallenge_TowerUI(_buf);
    }

    /// <summary>
    /// id
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 普通塔背景
    /// </summary>
    public readonly string normalBg;
    /// <summary>
    /// boss塔背景
    /// </summary>
    public readonly string bossBg;
    /// <summary>
    /// 塔顶奖励背景
    /// </summary>
    public readonly string topBg;
    /// <summary>
    /// 天空
    /// </summary>
    public readonly string sky;
    /// <summary>
    /// 可移动云彩
    /// </summary>
    public readonly string moveCloud;
    /// <summary>
    /// 静态云
    /// </summary>
    public readonly string staticCloud;
   
    public const int __ID__ = 544789368;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "normalBg:" + normalBg + ","
        + "bossBg:" + bossBg + ","
        + "topBg:" + topBg + ","
        + "sky:" + sky + ","
        + "moveCloud:" + moveCloud + ","
        + "staticCloud:" + staticCloud + ","
        + "}";
    }
}

}

