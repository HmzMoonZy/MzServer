
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
/// Generated from ChapterMiniGame.xlsx sheet slotBase
/// </summary>
public partial class TbChapterMiniGame_slotBase
{
    private readonly System.Collections.Generic.Dictionary<int, ChapterMiniGame_slotBase> _dataMap;
    private readonly System.Collections.Generic.List<ChapterMiniGame_slotBase> _dataList;
    
    public TbChapterMiniGame_slotBase(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ChapterMiniGame_slotBase>();
        _dataList = new System.Collections.Generic.List<ChapterMiniGame_slotBase>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ChapterMiniGame_slotBase _v;
            _v = global::HotFix.Cfg.ChapterMiniGame_slotBase.DeserializeChapterMiniGame_slotBase(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ChapterMiniGame_slotBase> DataMap => _dataMap;
    public System.Collections.Generic.List<ChapterMiniGame_slotBase> DataList => _dataList;

    public ChapterMiniGame_slotBase GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ChapterMiniGame_slotBase Get(int key) => _dataMap[key];
    public ChapterMiniGame_slotBase this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

