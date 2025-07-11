
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
/// Generated from MythicDungeon.xlsx sheet levelEvent
/// </summary>
public partial class TbMythicDungeon_levelEvent
{
    private readonly System.Collections.Generic.Dictionary<int, MythicDungeon_levelEvent> _dataMap;
    private readonly System.Collections.Generic.List<MythicDungeon_levelEvent> _dataList;
    
    public TbMythicDungeon_levelEvent(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, MythicDungeon_levelEvent>();
        _dataList = new System.Collections.Generic.List<MythicDungeon_levelEvent>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            MythicDungeon_levelEvent _v;
            _v = global::HotFix.Cfg.MythicDungeon_levelEvent.DeserializeMythicDungeon_levelEvent(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, MythicDungeon_levelEvent> DataMap => _dataMap;
    public System.Collections.Generic.List<MythicDungeon_levelEvent> DataList => _dataList;

    public MythicDungeon_levelEvent GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public MythicDungeon_levelEvent Get(int key) => _dataMap[key];
    public MythicDungeon_levelEvent this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

