
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
/// Generated from WorldBoss.xlsx sheet Reward
/// </summary>
public partial class TbWorldBoss_Reward
{
    private readonly System.Collections.Generic.Dictionary<int, WorldBoss_Reward> _dataMap;
    private readonly System.Collections.Generic.List<WorldBoss_Reward> _dataList;
    
    public TbWorldBoss_Reward(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, WorldBoss_Reward>();
        _dataList = new System.Collections.Generic.List<WorldBoss_Reward>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            WorldBoss_Reward _v;
            _v = global::HotFix.Cfg.WorldBoss_Reward.DeserializeWorldBoss_Reward(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.ID, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, WorldBoss_Reward> DataMap => _dataMap;
    public System.Collections.Generic.List<WorldBoss_Reward> DataList => _dataList;

    public WorldBoss_Reward GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public WorldBoss_Reward Get(int key) => _dataMap[key];
    public WorldBoss_Reward this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

