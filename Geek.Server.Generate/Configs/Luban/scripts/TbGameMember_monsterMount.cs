
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
/// Generated from GameMember.xlsx sheet monsterMount
/// </summary>
public partial class TbGameMember_monsterMount
{
    private readonly System.Collections.Generic.Dictionary<int, GameMember_monsterMount> _dataMap;
    private readonly System.Collections.Generic.List<GameMember_monsterMount> _dataList;
    
    public TbGameMember_monsterMount(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, GameMember_monsterMount>();
        _dataList = new System.Collections.Generic.List<GameMember_monsterMount>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            GameMember_monsterMount _v;
            _v = global::HotFix.Cfg.GameMember_monsterMount.DeserializeGameMember_monsterMount(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, GameMember_monsterMount> DataMap => _dataMap;
    public System.Collections.Generic.List<GameMember_monsterMount> DataList => _dataList;

    public GameMember_monsterMount GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GameMember_monsterMount Get(int key) => _dataMap[key];
    public GameMember_monsterMount this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

