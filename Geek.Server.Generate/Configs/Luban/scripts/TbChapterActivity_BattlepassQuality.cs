
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
/// Generated from ChapterActivity.xlsx sheet BattlepassQuality
/// </summary>
public partial class TbChapterActivity_BattlepassQuality
{
    private readonly System.Collections.Generic.Dictionary<int, ChapterActivity_BattlepassQuality> _dataMap;
    private readonly System.Collections.Generic.List<ChapterActivity_BattlepassQuality> _dataList;
    
    public TbChapterActivity_BattlepassQuality(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ChapterActivity_BattlepassQuality>();
        _dataList = new System.Collections.Generic.List<ChapterActivity_BattlepassQuality>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ChapterActivity_BattlepassQuality _v;
            _v = global::HotFix.Cfg.ChapterActivity_BattlepassQuality.DeserializeChapterActivity_BattlepassQuality(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ChapterActivity_BattlepassQuality> DataMap => _dataMap;
    public System.Collections.Generic.List<ChapterActivity_BattlepassQuality> DataList => _dataList;

    public ChapterActivity_BattlepassQuality GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ChapterActivity_BattlepassQuality Get(int key) => _dataMap[key];
    public ChapterActivity_BattlepassQuality this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

