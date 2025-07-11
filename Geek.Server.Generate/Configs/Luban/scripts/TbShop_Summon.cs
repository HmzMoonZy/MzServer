
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
/// Generated from Shop.xlsx sheet Summon
/// </summary>
public partial class TbShop_Summon
{
    private readonly System.Collections.Generic.Dictionary<int, Shop_Summon> _dataMap;
    private readonly System.Collections.Generic.List<Shop_Summon> _dataList;
    
    public TbShop_Summon(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Shop_Summon>();
        _dataList = new System.Collections.Generic.List<Shop_Summon>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Shop_Summon _v;
            _v = global::HotFix.Cfg.Shop_Summon.DeserializeShop_Summon(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Shop_Summon> DataMap => _dataMap;
    public System.Collections.Generic.List<Shop_Summon> DataList => _dataList;

    public Shop_Summon GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Shop_Summon Get(int key) => _dataMap[key];
    public Shop_Summon this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

