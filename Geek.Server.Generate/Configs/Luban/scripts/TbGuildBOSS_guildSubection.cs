
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
/// Generated from GuildBOSS.xlsx sheet guildSubection
/// </summary>
public partial class TbGuildBOSS_guildSubection
{
    private readonly System.Collections.Generic.Dictionary<int, GuildBOSS_guildSubection> _dataMap;
    private readonly System.Collections.Generic.List<GuildBOSS_guildSubection> _dataList;
    
    public TbGuildBOSS_guildSubection(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, GuildBOSS_guildSubection>();
        _dataList = new System.Collections.Generic.List<GuildBOSS_guildSubection>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            GuildBOSS_guildSubection _v;
            _v = global::HotFix.Cfg.GuildBOSS_guildSubection.DeserializeGuildBOSS_guildSubection(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, GuildBOSS_guildSubection> DataMap => _dataMap;
    public System.Collections.Generic.List<GuildBOSS_guildSubection> DataList => _dataList;

    public GuildBOSS_guildSubection GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GuildBOSS_guildSubection Get(int key) => _dataMap[key];
    public GuildBOSS_guildSubection this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

