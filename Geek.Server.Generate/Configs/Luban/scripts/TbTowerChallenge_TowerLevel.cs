
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
/// Generated from TowerChallenge.xlsx sheet TowerLevel
/// </summary>
public partial class TbTowerChallenge_TowerLevel
{
    private readonly System.Collections.Generic.Dictionary<int, TowerChallenge_TowerLevel> _dataMap;
    private readonly System.Collections.Generic.List<TowerChallenge_TowerLevel> _dataList;
    
    public TbTowerChallenge_TowerLevel(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, TowerChallenge_TowerLevel>();
        _dataList = new System.Collections.Generic.List<TowerChallenge_TowerLevel>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            TowerChallenge_TowerLevel _v;
            _v = global::HotFix.Cfg.TowerChallenge_TowerLevel.DeserializeTowerChallenge_TowerLevel(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, TowerChallenge_TowerLevel> DataMap => _dataMap;
    public System.Collections.Generic.List<TowerChallenge_TowerLevel> DataList => _dataList;

    public TowerChallenge_TowerLevel GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public TowerChallenge_TowerLevel Get(int key) => _dataMap[key];
    public TowerChallenge_TowerLevel this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

