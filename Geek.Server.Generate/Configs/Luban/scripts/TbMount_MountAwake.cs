
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
/// Generated from Mount.xlsx sheet MountAwake
/// </summary>
public partial class TbMount_MountAwake
{
    private readonly System.Collections.Generic.Dictionary<int, Mount_MountAwake> _dataMap;
    private readonly System.Collections.Generic.List<Mount_MountAwake> _dataList;
    
    public TbMount_MountAwake(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Mount_MountAwake>();
        _dataList = new System.Collections.Generic.List<Mount_MountAwake>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Mount_MountAwake _v;
            _v = global::HotFix.Cfg.Mount_MountAwake.DeserializeMount_MountAwake(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Mount_MountAwake> DataMap => _dataMap;
    public System.Collections.Generic.List<Mount_MountAwake> DataList => _dataList;

    public Mount_MountAwake GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Mount_MountAwake Get(int key) => _dataMap[key];
    public Mount_MountAwake this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

