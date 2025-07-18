
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
/// Generated from Mining.xlsx sheet miningBase
/// </summary>
public partial class TbMining_miningBase
{
    private readonly System.Collections.Generic.Dictionary<int, Mining_miningBase> _dataMap;
    private readonly System.Collections.Generic.List<Mining_miningBase> _dataList;
    
    public TbMining_miningBase(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Mining_miningBase>();
        _dataList = new System.Collections.Generic.List<Mining_miningBase>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Mining_miningBase _v;
            _v = global::HotFix.Cfg.Mining_miningBase.DeserializeMining_miningBase(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Mining_miningBase> DataMap => _dataMap;
    public System.Collections.Generic.List<Mining_miningBase> DataList => _dataList;

    public Mining_miningBase GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Mining_miningBase Get(int key) => _dataMap[key];
    public Mining_miningBase this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

