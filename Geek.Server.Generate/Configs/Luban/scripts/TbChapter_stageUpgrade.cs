
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
/// Generated from Chapter.xlsx sheet stageUpgrade
/// </summary>
public partial class TbChapter_stageUpgrade
{
    private readonly System.Collections.Generic.Dictionary<int, Chapter_stageUpgrade> _dataMap;
    private readonly System.Collections.Generic.List<Chapter_stageUpgrade> _dataList;
    
    public TbChapter_stageUpgrade(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Chapter_stageUpgrade>();
        _dataList = new System.Collections.Generic.List<Chapter_stageUpgrade>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Chapter_stageUpgrade _v;
            _v = global::HotFix.Cfg.Chapter_stageUpgrade.DeserializeChapter_stageUpgrade(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Chapter_stageUpgrade> DataMap => _dataMap;
    public System.Collections.Generic.List<Chapter_stageUpgrade> DataList => _dataList;

    public Chapter_stageUpgrade GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Chapter_stageUpgrade Get(int key) => _dataMap[key];
    public Chapter_stageUpgrade this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

