
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
/// Generated from TalentLegacy.xlsx sheet summonLegacy
/// </summary>
public partial class TbTalentLegacy_summonLegacy
{
    private readonly System.Collections.Generic.Dictionary<int, TalentLegacy_summonLegacy> _dataMap;
    private readonly System.Collections.Generic.List<TalentLegacy_summonLegacy> _dataList;
    
    public TbTalentLegacy_summonLegacy(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, TalentLegacy_summonLegacy>();
        _dataList = new System.Collections.Generic.List<TalentLegacy_summonLegacy>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            TalentLegacy_summonLegacy _v;
            _v = global::HotFix.Cfg.TalentLegacy_summonLegacy.DeserializeTalentLegacy_summonLegacy(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, TalentLegacy_summonLegacy> DataMap => _dataMap;
    public System.Collections.Generic.List<TalentLegacy_summonLegacy> DataList => _dataList;

    public TalentLegacy_summonLegacy GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public TalentLegacy_summonLegacy Get(int key) => _dataMap[key];
    public TalentLegacy_summonLegacy this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

