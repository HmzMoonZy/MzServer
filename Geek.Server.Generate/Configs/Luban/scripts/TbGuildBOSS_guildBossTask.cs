
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
/// Generated from GuildBOSS.xlsx sheet guildBossTask
/// </summary>
public partial class TbGuildBOSS_guildBossTask
{
    private readonly System.Collections.Generic.Dictionary<int, GuildBOSS_guildBossTask> _dataMap;
    private readonly System.Collections.Generic.List<GuildBOSS_guildBossTask> _dataList;
    
    public TbGuildBOSS_guildBossTask(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, GuildBOSS_guildBossTask>();
        _dataList = new System.Collections.Generic.List<GuildBOSS_guildBossTask>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            GuildBOSS_guildBossTask _v;
            _v = global::HotFix.Cfg.GuildBOSS_guildBossTask.DeserializeGuildBOSS_guildBossTask(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, GuildBOSS_guildBossTask> DataMap => _dataMap;
    public System.Collections.Generic.List<GuildBOSS_guildBossTask> DataList => _dataList;

    public GuildBOSS_guildBossTask GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GuildBOSS_guildBossTask Get(int key) => _dataMap[key];
    public GuildBOSS_guildBossTask this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

