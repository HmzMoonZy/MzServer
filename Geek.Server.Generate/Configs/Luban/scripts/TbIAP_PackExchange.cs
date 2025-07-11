
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
/// Generated from IAP.xlsx sheet PackExchange
/// </summary>
public partial class TbIAP_PackExchange
{
    private readonly System.Collections.Generic.Dictionary<int, IAP_PackExchange> _dataMap;
    private readonly System.Collections.Generic.List<IAP_PackExchange> _dataList;
    
    public TbIAP_PackExchange(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, IAP_PackExchange>();
        _dataList = new System.Collections.Generic.List<IAP_PackExchange>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            IAP_PackExchange _v;
            _v = global::HotFix.Cfg.IAP_PackExchange.DeserializeIAP_PackExchange(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, IAP_PackExchange> DataMap => _dataMap;
    public System.Collections.Generic.List<IAP_PackExchange> DataList => _dataList;

    public IAP_PackExchange GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public IAP_PackExchange Get(int key) => _dataMap[key];
    public IAP_PackExchange this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

