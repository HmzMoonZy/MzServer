
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
/// Generated from Chapter.xlsx sheet sweep
/// </summary>
public partial class TbChapter_sweep
{
    private readonly System.Collections.Generic.Dictionary<int, Chapter_sweep> _dataMap;
    private readonly System.Collections.Generic.List<Chapter_sweep> _dataList;
    
    public TbChapter_sweep(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Chapter_sweep>();
        _dataList = new System.Collections.Generic.List<Chapter_sweep>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Chapter_sweep _v;
            _v = global::HotFix.Cfg.Chapter_sweep.DeserializeChapter_sweep(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Chapter_sweep> DataMap => _dataMap;
    public System.Collections.Generic.List<Chapter_sweep> DataList => _dataList;

    public Chapter_sweep GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Chapter_sweep Get(int key) => _dataMap[key];
    public Chapter_sweep this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

