
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
/// Generated from ChristmasBoss.xlsx sheet christmasBossTask
/// </summary>
public partial class TbChristmasBoss_christmasBossTask
{
    private readonly System.Collections.Generic.Dictionary<int, ChristmasBoss_christmasBossTask> _dataMap;
    private readonly System.Collections.Generic.List<ChristmasBoss_christmasBossTask> _dataList;
    
    public TbChristmasBoss_christmasBossTask(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ChristmasBoss_christmasBossTask>();
        _dataList = new System.Collections.Generic.List<ChristmasBoss_christmasBossTask>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ChristmasBoss_christmasBossTask _v;
            _v = global::HotFix.Cfg.ChristmasBoss_christmasBossTask.DeserializeChristmasBoss_christmasBossTask(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ChristmasBoss_christmasBossTask> DataMap => _dataMap;
    public System.Collections.Generic.List<ChristmasBoss_christmasBossTask> DataList => _dataList;

    public ChristmasBoss_christmasBossTask GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ChristmasBoss_christmasBossTask Get(int key) => _dataMap[key];
    public ChristmasBoss_christmasBossTask this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

