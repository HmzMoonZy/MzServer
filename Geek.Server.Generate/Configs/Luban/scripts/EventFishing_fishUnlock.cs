
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
public sealed partial class EventFishing_fishUnlock : Luban.BeanBase
{
    public EventFishing_fishUnlock(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        UnlockWeight = _buf.ReadInt();
        UnlockFishRod = _buf.ReadInt();
        UnlockPayFishRod = _buf.ReadInt();
        UnlockArea = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);UnlockTask = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); UnlockTask[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);UnlockExchange = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); UnlockExchange[__index0] = __e0;}}
        UnlockLanguage = _buf.ReadString();
    }

    public static EventFishing_fishUnlock DeserializeEventFishing_fishUnlock(ByteBuf _buf)
    {
        return new EventFishing_fishUnlock(_buf);
    }

    /// <summary>
    /// ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 解锁所需重量g（百分数）
    /// </summary>
    public readonly int UnlockWeight;
    /// <summary>
    /// 解锁鱼竿
    /// </summary>
    public readonly int UnlockFishRod;
    /// <summary>
    /// 如果已拥有鱼竿，则解锁鱼竿
    /// </summary>
    public readonly int UnlockPayFishRod;
    /// <summary>
    /// 解锁区域
    /// </summary>
    public readonly int UnlockArea;
    /// <summary>
    /// 解锁任务ID
    /// </summary>
    public readonly int[] UnlockTask;
    /// <summary>
    /// 解锁兑换ID
    /// </summary>
    public readonly int[] UnlockExchange;
    /// <summary>
    /// 解锁目标显示多语言
    /// </summary>
    public readonly string UnlockLanguage;
   
    public const int __ID__ = -1153413973;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "UnlockWeight:" + UnlockWeight + ","
        + "UnlockFishRod:" + UnlockFishRod + ","
        + "UnlockPayFishRod:" + UnlockPayFishRod + ","
        + "UnlockArea:" + UnlockArea + ","
        + "UnlockTask:" + Luban.StringUtil.CollectionToString(UnlockTask) + ","
        + "UnlockExchange:" + Luban.StringUtil.CollectionToString(UnlockExchange) + ","
        + "UnlockLanguage:" + UnlockLanguage + ","
        + "}";
    }
}

}

