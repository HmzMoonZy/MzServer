
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
public sealed partial class TalentNew_talentMegaStage : Luban.BeanBase
{
    public TalentNew_talentMegaStage(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        languageId = _buf.ReadString();
        minStep = _buf.ReadInt();
        maxStep = _buf.ReadInt();
    }

    public static TalentNew_talentMegaStage DeserializeTalentNew_talentMegaStage(ByteBuf _buf)
    {
        return new TalentNew_talentMegaStage(_buf);
    }

    /// <summary>
    /// 进化ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 多语言
    /// </summary>
    public readonly string languageId;
    /// <summary>
    /// 最小等级
    /// </summary>
    public readonly int minStep;
    /// <summary>
    /// 最大等级
    /// </summary>
    public readonly int maxStep;
   
    public const int __ID__ = 779633877;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "languageId:" + languageId + ","
        + "minStep:" + minStep + ","
        + "maxStep:" + maxStep + ","
        + "}";
    }
}

}

