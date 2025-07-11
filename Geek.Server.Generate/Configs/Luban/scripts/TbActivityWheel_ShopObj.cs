
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
/// Generated from ActivityWheel.xlsx sheet ShopObj
/// </summary>
public partial class TbActivityWheel_ShopObj
{
    private readonly System.Collections.Generic.Dictionary<int, ActivityWheel_ShopObj> _dataMap;
    private readonly System.Collections.Generic.List<ActivityWheel_ShopObj> _dataList;
    
    public TbActivityWheel_ShopObj(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ActivityWheel_ShopObj>();
        _dataList = new System.Collections.Generic.List<ActivityWheel_ShopObj>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ActivityWheel_ShopObj _v;
            _v = global::HotFix.Cfg.ActivityWheel_ShopObj.DeserializeActivityWheel_ShopObj(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ActivityWheel_ShopObj> DataMap => _dataMap;
    public System.Collections.Generic.List<ActivityWheel_ShopObj> DataList => _dataList;

    public ActivityWheel_ShopObj GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ActivityWheel_ShopObj Get(int key) => _dataMap[key];
    public ActivityWheel_ShopObj this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

