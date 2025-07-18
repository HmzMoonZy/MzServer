
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
/// Generated from Fishing.xlsx sheet fishRod
/// </summary>
public partial class TbFishing_fishRod
{
    private readonly System.Collections.Generic.Dictionary<int, Fishing_fishRod> _dataMap;
    private readonly System.Collections.Generic.List<Fishing_fishRod> _dataList;
    
    public TbFishing_fishRod(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Fishing_fishRod>();
        _dataList = new System.Collections.Generic.List<Fishing_fishRod>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Fishing_fishRod _v;
            _v = global::HotFix.Cfg.Fishing_fishRod.DeserializeFishing_fishRod(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Fishing_fishRod> DataMap => _dataMap;
    public System.Collections.Generic.List<Fishing_fishRod> DataList => _dataList;

    public Fishing_fishRod GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Fishing_fishRod Get(int key) => _dataMap[key];
    public Fishing_fishRod this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

