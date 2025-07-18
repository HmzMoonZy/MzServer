
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
/// Generated from EventDive.xlsx sheet DiveSmallGrid
/// </summary>
public partial class TbEventDive_DiveSmallGrid
{
    private readonly System.Collections.Generic.Dictionary<int, EventDive_DiveSmallGrid> _dataMap;
    private readonly System.Collections.Generic.List<EventDive_DiveSmallGrid> _dataList;
    
    public TbEventDive_DiveSmallGrid(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, EventDive_DiveSmallGrid>();
        _dataList = new System.Collections.Generic.List<EventDive_DiveSmallGrid>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            EventDive_DiveSmallGrid _v;
            _v = global::HotFix.Cfg.EventDive_DiveSmallGrid.DeserializeEventDive_DiveSmallGrid(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, EventDive_DiveSmallGrid> DataMap => _dataMap;
    public System.Collections.Generic.List<EventDive_DiveSmallGrid> DataList => _dataList;

    public EventDive_DiveSmallGrid GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public EventDive_DiveSmallGrid Get(int key) => _dataMap[key];
    public EventDive_DiveSmallGrid this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

