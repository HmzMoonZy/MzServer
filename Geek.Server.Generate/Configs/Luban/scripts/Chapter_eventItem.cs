
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
public sealed partial class Chapter_eventItem : Luban.BeanBase
{
    public Chapter_eventItem(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        function = _buf.ReadInt();
        param = _buf.ReadString();
        stage = _buf.ReadInt();
        languageId = _buf.ReadString();
        atlas = _buf.ReadInt();
        icon = _buf.ReadString();
        showUI = _buf.ReadInt();
        isOverlay = _buf.ReadInt();
        costFood = _buf.ReadInt();
    }

    public static Chapter_eventItem DeserializeChapter_eventItem(ByteBuf _buf)
    {
        return new Chapter_eventItem(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 功能类型
    /// </summary>
    public readonly int function;
    /// <summary>
    /// 功能参数<br/>天气类型|是否黑天|是否切换特殊海浪
    /// </summary>
    public readonly string param;
    /// <summary>
    /// 持续天数
    /// </summary>
    public readonly int stage;
    /// <summary>
    /// 多语言
    /// </summary>
    public readonly string languageId;
    /// <summary>
    /// 图集
    /// </summary>
    public readonly int atlas;
    /// <summary>
    /// icon
    /// </summary>
    public readonly string icon;
    /// <summary>
    /// 是否在事件窗口显示获得
    /// </summary>
    public readonly int showUI;
    /// <summary>
    /// 是否可以叠加数量
    /// </summary>
    public readonly int isOverlay;
    /// <summary>
    /// 消耗食物
    /// </summary>
    public readonly int costFood;
   
    public const int __ID__ = -1337262277;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "function:" + function + ","
        + "param:" + param + ","
        + "stage:" + stage + ","
        + "languageId:" + languageId + ","
        + "atlas:" + atlas + ","
        + "icon:" + icon + ","
        + "showUI:" + showUI + ","
        + "isOverlay:" + isOverlay + ","
        + "costFood:" + costFood + ","
        + "}";
    }
}

}

