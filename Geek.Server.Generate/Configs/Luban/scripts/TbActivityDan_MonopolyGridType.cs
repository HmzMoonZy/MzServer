
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
/// Generated from ActivityDan.xlsx sheet MonopolyGridType
/// </summary>
public partial class TbActivityDan_MonopolyGridType
{
    private readonly System.Collections.Generic.Dictionary<int, ActivityDan_MonopolyGridType> _dataMap;
    private readonly System.Collections.Generic.List<ActivityDan_MonopolyGridType> _dataList;
    
    public TbActivityDan_MonopolyGridType(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ActivityDan_MonopolyGridType>();
        _dataList = new System.Collections.Generic.List<ActivityDan_MonopolyGridType>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ActivityDan_MonopolyGridType _v;
            _v = global::HotFix.Cfg.ActivityDan_MonopolyGridType.DeserializeActivityDan_MonopolyGridType(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ActivityDan_MonopolyGridType> DataMap => _dataMap;
    public System.Collections.Generic.List<ActivityDan_MonopolyGridType> DataList => _dataList;

    public ActivityDan_MonopolyGridType GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ActivityDan_MonopolyGridType Get(int key) => _dataMap[key];
    public ActivityDan_MonopolyGridType this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

