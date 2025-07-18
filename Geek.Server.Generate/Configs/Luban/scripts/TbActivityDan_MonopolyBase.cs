
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
/// Generated from ActivityDan.xlsx sheet MonopolyBase
/// </summary>
public partial class TbActivityDan_MonopolyBase
{
    private readonly System.Collections.Generic.Dictionary<int, ActivityDan_MonopolyBase> _dataMap;
    private readonly System.Collections.Generic.List<ActivityDan_MonopolyBase> _dataList;
    
    public TbActivityDan_MonopolyBase(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ActivityDan_MonopolyBase>();
        _dataList = new System.Collections.Generic.List<ActivityDan_MonopolyBase>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ActivityDan_MonopolyBase _v;
            _v = global::HotFix.Cfg.ActivityDan_MonopolyBase.DeserializeActivityDan_MonopolyBase(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ActivityDan_MonopolyBase> DataMap => _dataMap;
    public System.Collections.Generic.List<ActivityDan_MonopolyBase> DataList => _dataList;

    public ActivityDan_MonopolyBase GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ActivityDan_MonopolyBase Get(int key) => _dataMap[key];
    public ActivityDan_MonopolyBase this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

