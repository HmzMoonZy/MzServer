
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
/// Generated from Chapter.xlsx sheet skillExp
/// </summary>
public partial class TbChapter_skillExp
{
    private readonly System.Collections.Generic.Dictionary<int, Chapter_skillExp> _dataMap;
    private readonly System.Collections.Generic.List<Chapter_skillExp> _dataList;
    
    public TbChapter_skillExp(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Chapter_skillExp>();
        _dataList = new System.Collections.Generic.List<Chapter_skillExp>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Chapter_skillExp _v;
            _v = global::HotFix.Cfg.Chapter_skillExp.DeserializeChapter_skillExp(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Chapter_skillExp> DataMap => _dataMap;
    public System.Collections.Generic.List<Chapter_skillExp> DataList => _dataList;

    public Chapter_skillExp GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Chapter_skillExp Get(int key) => _dataMap[key];
    public Chapter_skillExp this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

