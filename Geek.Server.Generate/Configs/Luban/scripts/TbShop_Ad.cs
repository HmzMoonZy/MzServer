
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
/// Generated from Shop.xlsx sheet Ad
/// </summary>
public partial class TbShop_Ad
{
    private readonly System.Collections.Generic.Dictionary<int, Shop_Ad> _dataMap;
    private readonly System.Collections.Generic.List<Shop_Ad> _dataList;
    
    public TbShop_Ad(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Shop_Ad>();
        _dataList = new System.Collections.Generic.List<Shop_Ad>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Shop_Ad _v;
            _v = global::HotFix.Cfg.Shop_Ad.DeserializeShop_Ad(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Shop_Ad> DataMap => _dataMap;
    public System.Collections.Generic.List<Shop_Ad> DataList => _dataList;

    public Shop_Ad GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Shop_Ad Get(int key) => _dataMap[key];
    public Shop_Ad this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

