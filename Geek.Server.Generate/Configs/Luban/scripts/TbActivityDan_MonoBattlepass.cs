
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
/// Generated from ActivityDan.xlsx sheet MonoBattlepass
/// </summary>
public partial class TbActivityDan_MonoBattlepass
{
    private readonly System.Collections.Generic.Dictionary<int, ActivityDan_MonoBattlepass> _dataMap;
    private readonly System.Collections.Generic.List<ActivityDan_MonoBattlepass> _dataList;
    
    public TbActivityDan_MonoBattlepass(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ActivityDan_MonoBattlepass>();
        _dataList = new System.Collections.Generic.List<ActivityDan_MonoBattlepass>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ActivityDan_MonoBattlepass _v;
            _v = global::HotFix.Cfg.ActivityDan_MonoBattlepass.DeserializeActivityDan_MonoBattlepass(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ActivityDan_MonoBattlepass> DataMap => _dataMap;
    public System.Collections.Generic.List<ActivityDan_MonoBattlepass> DataList => _dataList;

    public ActivityDan_MonoBattlepass GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ActivityDan_MonoBattlepass Get(int key) => _dataMap[key];
    public ActivityDan_MonoBattlepass this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

