
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
public sealed partial class Mining_oreQuality : Luban.BeanBase
{
    public Mining_oreQuality(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        upgradeRate = _buf.ReadInt();
        languageId = _buf.ReadString();
    }

    public static Mining_oreQuality DeserializeMining_oreQuality(ByteBuf _buf)
    {
        return new Mining_oreQuality(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 升品概率（万分比）
    /// </summary>
    public readonly int upgradeRate;
    /// <summary>
    /// 多语言
    /// </summary>
    public readonly string languageId;
   
    public const int __ID__ = 1442927340;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "upgradeRate:" + upgradeRate + ","
        + "languageId:" + languageId + ","
        + "}";
    }
}

}

