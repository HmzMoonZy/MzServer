
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
/// Generated from GameSkill.xlsx sheet hitEffect
/// </summary>
public partial class TbGameSkill_hitEffect
{
    private readonly System.Collections.Generic.Dictionary<int, GameSkill_hitEffect> _dataMap;
    private readonly System.Collections.Generic.List<GameSkill_hitEffect> _dataList;
    
    public TbGameSkill_hitEffect(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, GameSkill_hitEffect>();
        _dataList = new System.Collections.Generic.List<GameSkill_hitEffect>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            GameSkill_hitEffect _v;
            _v = global::HotFix.Cfg.GameSkill_hitEffect.DeserializeGameSkill_hitEffect(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, GameSkill_hitEffect> DataMap => _dataMap;
    public System.Collections.Generic.List<GameSkill_hitEffect> DataList => _dataList;

    public GameSkill_hitEffect GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GameSkill_hitEffect Get(int key) => _dataMap[key];
    public GameSkill_hitEffect this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

