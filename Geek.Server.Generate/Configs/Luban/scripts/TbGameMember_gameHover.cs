
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
/// Generated from GameMember.xlsx sheet gameHover
/// </summary>
public partial class TbGameMember_gameHover
{
    private readonly System.Collections.Generic.Dictionary<int, GameMember_gameHover> _dataMap;
    private readonly System.Collections.Generic.List<GameMember_gameHover> _dataList;
    
    public TbGameMember_gameHover(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, GameMember_gameHover>();
        _dataList = new System.Collections.Generic.List<GameMember_gameHover>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            GameMember_gameHover _v;
            _v = global::HotFix.Cfg.GameMember_gameHover.DeserializeGameMember_gameHover(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, GameMember_gameHover> DataMap => _dataMap;
    public System.Collections.Generic.List<GameMember_gameHover> DataList => _dataList;

    public GameMember_gameHover GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GameMember_gameHover Get(int key) => _dataMap[key];
    public GameMember_gameHover this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

