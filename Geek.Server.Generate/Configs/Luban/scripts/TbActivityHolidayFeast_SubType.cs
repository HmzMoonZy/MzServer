
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
/// Generated from ActivityHolidayFeast.xlsx sheet SubType
/// </summary>
public partial class TbActivityHolidayFeast_SubType
{
    private readonly System.Collections.Generic.Dictionary<int, ActivityHolidayFeast_SubType> _dataMap;
    private readonly System.Collections.Generic.List<ActivityHolidayFeast_SubType> _dataList;
    
    public TbActivityHolidayFeast_SubType(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ActivityHolidayFeast_SubType>();
        _dataList = new System.Collections.Generic.List<ActivityHolidayFeast_SubType>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ActivityHolidayFeast_SubType _v;
            _v = global::HotFix.Cfg.ActivityHolidayFeast_SubType.DeserializeActivityHolidayFeast_SubType(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ActivityHolidayFeast_SubType> DataMap => _dataMap;
    public System.Collections.Generic.List<ActivityHolidayFeast_SubType> DataList => _dataList;

    public ActivityHolidayFeast_SubType GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ActivityHolidayFeast_SubType Get(int key) => _dataMap[key];
    public ActivityHolidayFeast_SubType this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

