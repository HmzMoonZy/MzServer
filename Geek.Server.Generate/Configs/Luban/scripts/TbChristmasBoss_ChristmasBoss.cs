
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
/// Generated from ChristmasBoss.xlsx sheet ChristmasBoss
/// </summary>
public partial class TbChristmasBoss_ChristmasBoss
{
    private readonly System.Collections.Generic.Dictionary<int, ChristmasBoss_ChristmasBoss> _dataMap;
    private readonly System.Collections.Generic.List<ChristmasBoss_ChristmasBoss> _dataList;
    
    public TbChristmasBoss_ChristmasBoss(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ChristmasBoss_ChristmasBoss>();
        _dataList = new System.Collections.Generic.List<ChristmasBoss_ChristmasBoss>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ChristmasBoss_ChristmasBoss _v;
            _v = global::HotFix.Cfg.ChristmasBoss_ChristmasBoss.DeserializeChristmasBoss_ChristmasBoss(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ChristmasBoss_ChristmasBoss> DataMap => _dataMap;
    public System.Collections.Generic.List<ChristmasBoss_ChristmasBoss> DataList => _dataList;

    public ChristmasBoss_ChristmasBoss GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ChristmasBoss_ChristmasBoss Get(int key) => _dataMap[key];
    public ChristmasBoss_ChristmasBoss this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

