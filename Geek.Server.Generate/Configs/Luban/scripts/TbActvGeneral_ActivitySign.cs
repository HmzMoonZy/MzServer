
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
/// Generated from ActvGeneral.xlsx sheet ActivitySign
/// </summary>
public partial class TbActvGeneral_ActivitySign
{
    private readonly System.Collections.Generic.Dictionary<int, ActvGeneral_ActivitySign> _dataMap;
    private readonly System.Collections.Generic.List<ActvGeneral_ActivitySign> _dataList;
    
    public TbActvGeneral_ActivitySign(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ActvGeneral_ActivitySign>();
        _dataList = new System.Collections.Generic.List<ActvGeneral_ActivitySign>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ActvGeneral_ActivitySign _v;
            _v = global::HotFix.Cfg.ActvGeneral_ActivitySign.DeserializeActvGeneral_ActivitySign(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ActvGeneral_ActivitySign> DataMap => _dataMap;
    public System.Collections.Generic.List<ActvGeneral_ActivitySign> DataList => _dataList;

    public ActvGeneral_ActivitySign GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ActvGeneral_ActivitySign Get(int key) => _dataMap[key];
    public ActvGeneral_ActivitySign this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

