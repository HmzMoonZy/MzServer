
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
/// Generated from TGASource.xlsx sheet Page
/// </summary>
public partial class TbTGASource_Page
{
    private readonly System.Collections.Generic.Dictionary<string, TGASource_Page> _dataMap;
    private readonly System.Collections.Generic.List<TGASource_Page> _dataList;
    
    public TbTGASource_Page(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<string, TGASource_Page>();
        _dataList = new System.Collections.Generic.List<TGASource_Page>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            TGASource_Page _v;
            _v = global::HotFix.Cfg.TGASource_Page.DeserializeTGASource_Page(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<string, TGASource_Page> DataMap => _dataMap;
    public System.Collections.Generic.List<TGASource_Page> DataList => _dataList;

    public TGASource_Page GetOrDefault(string key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public TGASource_Page Get(string key) => _dataMap[key];
    public TGASource_Page this[string key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

