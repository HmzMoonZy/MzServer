
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
/// <summary>
/// Generated from Quality.xlsx sheet guildBossQuality
/// </summary>
public partial class TbQuality_guildBossQuality
{
    private readonly System.Collections.Generic.Dictionary<int, Quality_guildBossQuality> _dataMap;
    private readonly System.Collections.Generic.List<Quality_guildBossQuality> _dataList;
    
    public TbQuality_guildBossQuality(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Quality_guildBossQuality>();
        _dataList = new System.Collections.Generic.List<Quality_guildBossQuality>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Quality_guildBossQuality _v;
            _v = global::HotFix.Cfg.Quality_guildBossQuality.DeserializeQuality_guildBossQuality(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Quality_guildBossQuality> DataMap => _dataMap;
    public System.Collections.Generic.List<Quality_guildBossQuality> DataList => _dataList;

    public Quality_guildBossQuality GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Quality_guildBossQuality Get(int key) => _dataMap[key];
    public Quality_guildBossQuality this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

