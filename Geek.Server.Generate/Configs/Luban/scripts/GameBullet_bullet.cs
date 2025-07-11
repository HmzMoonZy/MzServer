
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
public sealed partial class GameBullet_bullet : Luban.BeanBase
{
    public GameBullet_bullet(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        prefabID = _buf.ReadInt();
        bulletType = _buf.ReadInt();
        parameters = _buf.ReadString();
        frame = _buf.ReadInt();
        shakeID = _buf.ReadInt();
        hitAddBuffs = _buf.ReadString();
        destroyDuation = _buf.ReadFloat();
    }

    public static GameBullet_bullet DeserializeGameBullet_bullet(ByteBuf _buf)
    {
        return new GameBullet_bullet(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 触发特效（指向ArtBullet）
    /// </summary>
    public readonly int prefabID;
    /// <summary>
    /// 子弹类型ID
    /// </summary>
    public readonly int bulletType;
    /// <summary>
    /// 默认参数
    /// </summary>
    public readonly string parameters;
    /// <summary>
    /// 帧数后伤害（飞行时间）
    /// </summary>
    public readonly int frame;
    /// <summary>
    ///  震屏
    /// </summary>
    public readonly int shakeID;
    /// <summary>
    /// 子弹命中增加Buff
    /// </summary>
    public readonly string hitAddBuffs;
    /// <summary>
    /// 结束后删除等待时间
    /// </summary>
    public readonly float destroyDuation;
   
    public const int __ID__ = -132885523;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "prefabID:" + prefabID + ","
        + "bulletType:" + bulletType + ","
        + "parameters:" + parameters + ","
        + "frame:" + frame + ","
        + "shakeID:" + shakeID + ","
        + "hitAddBuffs:" + hitAddBuffs + ","
        + "destroyDuation:" + destroyDuation + ","
        + "}";
    }
}

}

