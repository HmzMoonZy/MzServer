
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
/// Generated from FestivalTurntable.xlsx sheet FestivalTurntableQuest
/// </summary>
public partial class TbFestivalTurntable_FestivalTurntableQuest
{
    private readonly System.Collections.Generic.Dictionary<int, FestivalTurntable_FestivalTurntableQuest> _dataMap;
    private readonly System.Collections.Generic.List<FestivalTurntable_FestivalTurntableQuest> _dataList;
    
    public TbFestivalTurntable_FestivalTurntableQuest(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, FestivalTurntable_FestivalTurntableQuest>();
        _dataList = new System.Collections.Generic.List<FestivalTurntable_FestivalTurntableQuest>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            FestivalTurntable_FestivalTurntableQuest _v;
            _v = global::HotFix.Cfg.FestivalTurntable_FestivalTurntableQuest.DeserializeFestivalTurntable_FestivalTurntableQuest(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, FestivalTurntable_FestivalTurntableQuest> DataMap => _dataMap;
    public System.Collections.Generic.List<FestivalTurntable_FestivalTurntableQuest> DataList => _dataList;

    public FestivalTurntable_FestivalTurntableQuest GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public FestivalTurntable_FestivalTurntableQuest Get(int key) => _dataMap[key];
    public FestivalTurntable_FestivalTurntableQuest this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

