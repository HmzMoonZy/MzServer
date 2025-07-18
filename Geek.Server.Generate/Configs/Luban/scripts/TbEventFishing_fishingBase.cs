
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
/// Generated from EventFishing.xlsx sheet fishingBase
/// </summary>
public partial class TbEventFishing_fishingBase
{
    private readonly System.Collections.Generic.Dictionary<int, EventFishing_fishingBase> _dataMap;
    private readonly System.Collections.Generic.List<EventFishing_fishingBase> _dataList;
    
    public TbEventFishing_fishingBase(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, EventFishing_fishingBase>();
        _dataList = new System.Collections.Generic.List<EventFishing_fishingBase>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            EventFishing_fishingBase _v;
            _v = global::HotFix.Cfg.EventFishing_fishingBase.DeserializeEventFishing_fishingBase(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, EventFishing_fishingBase> DataMap => _dataMap;
    public System.Collections.Generic.List<EventFishing_fishingBase> DataList => _dataList;

    public EventFishing_fishingBase GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public EventFishing_fishingBase Get(int key) => _dataMap[key];
    public EventFishing_fishingBase this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

