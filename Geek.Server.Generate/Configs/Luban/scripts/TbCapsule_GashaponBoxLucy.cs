
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
/// Generated from Capsule.xlsx sheet GashaponBoxLucy
/// </summary>
public partial class TbCapsule_GashaponBoxLucy
{
    private readonly System.Collections.Generic.Dictionary<int, Capsule_GashaponBoxLucy> _dataMap;
    private readonly System.Collections.Generic.List<Capsule_GashaponBoxLucy> _dataList;
    
    public TbCapsule_GashaponBoxLucy(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Capsule_GashaponBoxLucy>();
        _dataList = new System.Collections.Generic.List<Capsule_GashaponBoxLucy>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Capsule_GashaponBoxLucy _v;
            _v = global::HotFix.Cfg.Capsule_GashaponBoxLucy.DeserializeCapsule_GashaponBoxLucy(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Capsule_GashaponBoxLucy> DataMap => _dataMap;
    public System.Collections.Generic.List<Capsule_GashaponBoxLucy> DataList => _dataList;

    public Capsule_GashaponBoxLucy GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Capsule_GashaponBoxLucy Get(int key) => _dataMap[key];
    public Capsule_GashaponBoxLucy this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

