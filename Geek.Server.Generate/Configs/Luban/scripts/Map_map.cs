
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
public sealed partial class Map_map : Luban.BeanBase
{
    public Map_map(ByteBuf _buf) 
    {
        id = _buf.ReadInt();
        mapType = _buf.ReadInt();
        bottomType = _buf.ReadInt();
        bottomPointName = _buf.ReadString();
        nameId = _buf.ReadString();
        bossArtMap = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);playerOffset = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); playerOffset[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);petOffset = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); petOffset[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);skyIDs = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); skyIDs[__index0] = __e0;}}
        skyOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);bgIds = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); bgIds[__index0] = __e0;}}
        bgOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);bgSpeed = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); bgSpeed[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);farIDs = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); farIDs[__index0] = __e0;}}
        farOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);farSpeed = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); farSpeed[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);middleIDs = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); middleIDs[__index0] = __e0;}}
        middleOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);nearIDs = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); nearIDs[__index0] = __e0;}}
        nearOffsetY = _buf.ReadFloat();
        waveOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);normalWaves = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); normalWaves[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);specialWaves = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); specialWaves[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);clouds = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); clouds[__index0] = __e0;}}
        cloudOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);cloudSpeed = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); cloudSpeed[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);farFloating = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); farFloating[__index0] = __e0;}}
        farFloatingOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);farFloatingSpeed = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); farFloatingSpeed[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);farStatic = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); farStatic[__index0] = __e0;}}
        farStaticOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);middleFloating = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); middleFloating[__index0] = __e0;}}
        middleFloatingOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);nearFloating = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); nearFloating[__index0] = __e0;}}
        nearFloatingOffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);nearFloatingSpeed = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); nearFloatingSpeed[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);floatingRandom = new int[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { int __e0;__e0 = _buf.ReadInt(); floatingRandom[__index0] = __e0;}}
        isPlanet = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);planetOffset = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); planetOffset[__index0] = __e0;}}
        hangupOffsetY = _buf.ReadFloat();
        hangupPlayerY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);memberColor = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); memberColor[__index0] = __e0;}}
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);spriteColor = new float[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { float __e0;__e0 = _buf.ReadFloat(); spriteColor[__index0] = __e0;}}
        changeTime = _buf.ReadInt();
        matPrefix = _buf.ReadString();
        activityMap = _buf.ReadInt();
        activityLightColor = _buf.ReadString();
        activityStarColor = _buf.ReadString();
        activityButtonBg = _buf.ReadInt();
        ride = _buf.ReadInt();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);groundTex1Ids = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); groundTex1Ids[__index0] = __e0;}}
        groundTex1OffsetY = _buf.ReadFloat();
        {int __n0 = System.Math.Min(_buf.ReadSize(), _buf.Size);groundTex2Ids = new string[__n0];for(var __index0 = 0 ; __index0 < __n0 ; __index0++) { string __e0;__e0 = _buf.ReadString(); groundTex2Ids[__index0] = __e0;}}
        groundTex2OffsetY = _buf.ReadFloat();
        groundTexColor = _buf.ReadString();
    }

    public static Map_map DeserializeMap_map(ByteBuf _buf)
    {
        return new Map_map(_buf);
    }

    /// <summary>
    /// 内容ID
    /// </summary>
    public readonly int id;
    /// <summary>
    /// 地图类型<br/>0海洋 1陆地
    /// </summary>
    public readonly int mapType;
    /// <summary>
    /// 底座类型<br/>0无 1 海洋 2 陆地
    /// </summary>
    public readonly int bottomType;
    /// <summary>
    /// 底座挂点名称
    /// </summary>
    public readonly string bottomPointName;
    /// <summary>
    /// 章节名ID
    /// </summary>
    public readonly string nameId;
    /// <summary>
    /// S1赛季Boss战特殊地图
    /// </summary>
    public readonly int bossArtMap;
    /// <summary>
    /// 玩家偏移
    /// </summary>
    public readonly float[] playerOffset;
    /// <summary>
    /// 宠物1偏移|宠物2偏移
    /// </summary>
    public readonly string[] petOffset;
    /// <summary>
    /// 天空层<br/>白天1,2,3|黄昏1,2,3|夜晚1,2,3
    /// </summary>
    public readonly string[] skyIDs;
    /// <summary>
    /// 天空层Y轴偏移量
    /// </summary>
    public readonly float skyOffsetY;
    /// <summary>
    /// 背景层<br/>白天1,2,3|黄昏1,2,3|夜晚1,2,3
    /// </summary>
    public readonly string[] bgIds;
    /// <summary>
    /// 背景层Y轴偏移
    /// </summary>
    public readonly float bgOffsetY;
    /// <summary>
    /// 背景速度偏移<br/>普通|加速|挂机
    /// </summary>
    public readonly float[] bgSpeed;
    /// <summary>
    /// 远景层<br/>白天1,2,3|黄昏1,2,3|夜晚1,2,3
    /// </summary>
    public readonly string[] farIDs;
    /// <summary>
    /// 远景层Y轴偏移量
    /// </summary>
    public readonly float farOffsetY;
    /// <summary>
    /// 远景速度偏移<br/>普通|加速|挂机
    /// </summary>
    public readonly float[] farSpeed;
    /// <summary>
    /// 中景层<br/>白天1,2,3|黄昏1,2,3|夜晚1,2,3
    /// </summary>
    public readonly string[] middleIDs;
    /// <summary>
    /// 中景层Y轴偏移量
    /// </summary>
    public readonly float middleOffsetY;
    /// <summary>
    /// 近景层<br/>白天1,2,3|黄昏1,2,3|夜晚1,2,3
    /// </summary>
    public readonly string[] nearIDs;
    /// <summary>
    /// 近景层Y轴偏移量
    /// </summary>
    public readonly float nearOffsetY;
    /// <summary>
    /// 海浪Y轴偏移量
    /// </summary>
    public readonly float waveOffsetY;
    /// <summary>
    /// 默认海浪
    /// </summary>
    public readonly int[] normalWaves;
    /// <summary>
    /// 特殊海浪
    /// </summary>
    public readonly int[] specialWaves;
    /// <summary>
    /// 云彩
    /// </summary>
    public readonly int[] clouds;
    /// <summary>
    /// 云彩Y轴偏移
    /// </summary>
    public readonly float cloudOffsetY;
    /// <summary>
    /// 云彩速度偏移<br/>普通|加速|挂机
    /// </summary>
    public readonly float[] cloudSpeed;
    /// <summary>
    /// 远景漂浮物
    /// </summary>
    public readonly int[] farFloating;
    /// <summary>
    /// 远景漂浮物Y轴偏移
    /// </summary>
    public readonly float farFloatingOffsetY;
    /// <summary>
    /// 远景漂浮物速度偏移<br/>普通|加速|挂机
    /// </summary>
    public readonly float[] farFloatingSpeed;
    /// <summary>
    /// 远景静态装饰物
    /// </summary>
    public readonly int[] farStatic;
    /// <summary>
    /// 远景静态装饰物Y轴偏移
    /// </summary>
    public readonly float farStaticOffsetY;
    /// <summary>
    /// 中景漂浮物
    /// </summary>
    public readonly int[] middleFloating;
    /// <summary>
    /// 中景漂浮物Y轴偏移
    /// </summary>
    public readonly float middleFloatingOffsetY;
    /// <summary>
    /// 近景漂浮物
    /// </summary>
    public readonly int[] nearFloating;
    /// <summary>
    /// 近景漂浮物Y轴偏移
    /// </summary>
    public readonly float nearFloatingOffsetY;
    /// <summary>
    /// 近景漂浮物速度偏移<br/>普通|加速|挂机
    /// </summary>
    public readonly float[] nearFloatingSpeed;
    /// <summary>
    /// 漂浮物随机<br/>云|动态远景|中景|近景|静态远景
    /// </summary>
    public readonly int[] floatingRandom;
    /// <summary>
    /// 是否显示太阳和月亮
    /// </summary>
    public readonly int isPlanet;
    /// <summary>
    /// 星球层偏移<br/>X|Y
    /// </summary>
    public readonly float[] planetOffset;
    /// <summary>
    /// 挂机地图偏移
    /// </summary>
    public readonly float hangupOffsetY;
    /// <summary>
    /// 挂机角色偏移
    /// </summary>
    public readonly float hangupPlayerY;
    /// <summary>
    /// 角色时辰颜色变化<br/>白天|黄昏|夜晚
    /// </summary>
    public readonly float[] memberColor;
    /// <summary>
    /// 静态图时辰颜色变化<br/>白天|黄昏|夜晚
    /// </summary>
    public readonly float[] spriteColor;
    /// <summary>
    /// 是否随机时辰
    /// </summary>
    public readonly int changeTime;
    /// <summary>
    /// 材质球前缀
    /// </summary>
    public readonly string matPrefix;
    /// <summary>
    /// 章节活动背景ID
    /// </summary>
    public readonly int activityMap;
    /// <summary>
    /// 光颜色
    /// </summary>
    public readonly string activityLightColor;
    /// <summary>
    /// 星星颜色
    /// </summary>
    public readonly string activityStarColor;
    /// <summary>
    /// 章节活动按钮背景
    /// </summary>
    public readonly int activityButtonBg;
    /// <summary>
    /// 载具
    /// </summary>
    public readonly int ride;
    /// <summary>
    /// 地面纹理层1<br/>白天1,2,3|黄昏1,2,3|夜晚1,2,3
    /// </summary>
    public readonly string[] groundTex1Ids;
    /// <summary>
    /// 纹理层1Y轴偏移量
    /// </summary>
    public readonly float groundTex1OffsetY;
    /// <summary>
    /// 地面纹理层2<br/>白天1,2,3|黄昏1,2,3|夜晚1,2,3
    /// </summary>
    public readonly string[] groundTex2Ids;
    /// <summary>
    /// 纹理层2Y轴偏移量
    /// </summary>
    public readonly float groundTex2OffsetY;
    /// <summary>
    /// 地面纹理层颜色<br/>16进制色值必须以#开始
    /// </summary>
    public readonly string groundTexColor;
   
    public const int __ID__ = -1793260583;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + id + ","
        + "mapType:" + mapType + ","
        + "bottomType:" + bottomType + ","
        + "bottomPointName:" + bottomPointName + ","
        + "nameId:" + nameId + ","
        + "bossArtMap:" + bossArtMap + ","
        + "playerOffset:" + Luban.StringUtil.CollectionToString(playerOffset) + ","
        + "petOffset:" + Luban.StringUtil.CollectionToString(petOffset) + ","
        + "skyIDs:" + Luban.StringUtil.CollectionToString(skyIDs) + ","
        + "skyOffsetY:" + skyOffsetY + ","
        + "bgIds:" + Luban.StringUtil.CollectionToString(bgIds) + ","
        + "bgOffsetY:" + bgOffsetY + ","
        + "bgSpeed:" + Luban.StringUtil.CollectionToString(bgSpeed) + ","
        + "farIDs:" + Luban.StringUtil.CollectionToString(farIDs) + ","
        + "farOffsetY:" + farOffsetY + ","
        + "farSpeed:" + Luban.StringUtil.CollectionToString(farSpeed) + ","
        + "middleIDs:" + Luban.StringUtil.CollectionToString(middleIDs) + ","
        + "middleOffsetY:" + middleOffsetY + ","
        + "nearIDs:" + Luban.StringUtil.CollectionToString(nearIDs) + ","
        + "nearOffsetY:" + nearOffsetY + ","
        + "waveOffsetY:" + waveOffsetY + ","
        + "normalWaves:" + Luban.StringUtil.CollectionToString(normalWaves) + ","
        + "specialWaves:" + Luban.StringUtil.CollectionToString(specialWaves) + ","
        + "clouds:" + Luban.StringUtil.CollectionToString(clouds) + ","
        + "cloudOffsetY:" + cloudOffsetY + ","
        + "cloudSpeed:" + Luban.StringUtil.CollectionToString(cloudSpeed) + ","
        + "farFloating:" + Luban.StringUtil.CollectionToString(farFloating) + ","
        + "farFloatingOffsetY:" + farFloatingOffsetY + ","
        + "farFloatingSpeed:" + Luban.StringUtil.CollectionToString(farFloatingSpeed) + ","
        + "farStatic:" + Luban.StringUtil.CollectionToString(farStatic) + ","
        + "farStaticOffsetY:" + farStaticOffsetY + ","
        + "middleFloating:" + Luban.StringUtil.CollectionToString(middleFloating) + ","
        + "middleFloatingOffsetY:" + middleFloatingOffsetY + ","
        + "nearFloating:" + Luban.StringUtil.CollectionToString(nearFloating) + ","
        + "nearFloatingOffsetY:" + nearFloatingOffsetY + ","
        + "nearFloatingSpeed:" + Luban.StringUtil.CollectionToString(nearFloatingSpeed) + ","
        + "floatingRandom:" + Luban.StringUtil.CollectionToString(floatingRandom) + ","
        + "isPlanet:" + isPlanet + ","
        + "planetOffset:" + Luban.StringUtil.CollectionToString(planetOffset) + ","
        + "hangupOffsetY:" + hangupOffsetY + ","
        + "hangupPlayerY:" + hangupPlayerY + ","
        + "memberColor:" + Luban.StringUtil.CollectionToString(memberColor) + ","
        + "spriteColor:" + Luban.StringUtil.CollectionToString(spriteColor) + ","
        + "changeTime:" + changeTime + ","
        + "matPrefix:" + matPrefix + ","
        + "activityMap:" + activityMap + ","
        + "activityLightColor:" + activityLightColor + ","
        + "activityStarColor:" + activityStarColor + ","
        + "activityButtonBg:" + activityButtonBg + ","
        + "ride:" + ride + ","
        + "groundTex1Ids:" + Luban.StringUtil.CollectionToString(groundTex1Ids) + ","
        + "groundTex1OffsetY:" + groundTex1OffsetY + ","
        + "groundTex2Ids:" + Luban.StringUtil.CollectionToString(groundTex2Ids) + ","
        + "groundTex2OffsetY:" + groundTex2OffsetY + ","
        + "groundTexColor:" + groundTexColor + ","
        + "}";
    }
}

}

