
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
/// Generated from Map.xlsx sheet map
/// </summary>
public partial class TbMap_map
{
    private readonly System.Collections.Generic.Dictionary<int, Map_map> _dataMap;
    private readonly System.Collections.Generic.List<Map_map> _dataList;
    
    public TbMap_map(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Map_map>();
        _dataList = new System.Collections.Generic.List<Map_map>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Map_map _v;
            _v = global::HotFix.Cfg.Map_map.DeserializeMap_map(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Map_map> DataMap => _dataMap;
    public System.Collections.Generic.List<Map_map> DataList => _dataList;

    public Map_map GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Map_map Get(int key) => _dataMap[key];
    public Map_map this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

