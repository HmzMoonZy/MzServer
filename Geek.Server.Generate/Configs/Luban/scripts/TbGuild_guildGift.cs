
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
/// Generated from Guild.xlsx sheet guildGift
/// </summary>
public partial class TbGuild_guildGift
{
    private readonly System.Collections.Generic.Dictionary<int, Guild_guildGift> _dataMap;
    private readonly System.Collections.Generic.List<Guild_guildGift> _dataList;
    
    public TbGuild_guildGift(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Guild_guildGift>();
        _dataList = new System.Collections.Generic.List<Guild_guildGift>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Guild_guildGift _v;
            _v = global::HotFix.Cfg.Guild_guildGift.DeserializeGuild_guildGift(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Guild_guildGift> DataMap => _dataMap;
    public System.Collections.Generic.List<Guild_guildGift> DataList => _dataList;

    public Guild_guildGift GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Guild_guildGift Get(int key) => _dataMap[key];
    public Guild_guildGift this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

