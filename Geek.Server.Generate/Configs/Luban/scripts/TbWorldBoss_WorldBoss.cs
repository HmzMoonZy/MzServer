
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
/// Generated from WorldBoss.xlsx sheet WorldBoss
/// </summary>
public partial class TbWorldBoss_WorldBoss
{
    private readonly System.Collections.Generic.Dictionary<int, WorldBoss_WorldBoss> _dataMap;
    private readonly System.Collections.Generic.List<WorldBoss_WorldBoss> _dataList;
    
    public TbWorldBoss_WorldBoss(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, WorldBoss_WorldBoss>();
        _dataList = new System.Collections.Generic.List<WorldBoss_WorldBoss>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            WorldBoss_WorldBoss _v;
            _v = global::HotFix.Cfg.WorldBoss_WorldBoss.DeserializeWorldBoss_WorldBoss(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, WorldBoss_WorldBoss> DataMap => _dataMap;
    public System.Collections.Generic.List<WorldBoss_WorldBoss> DataList => _dataList;

    public WorldBoss_WorldBoss GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public WorldBoss_WorldBoss Get(int key) => _dataMap[key];
    public WorldBoss_WorldBoss this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

