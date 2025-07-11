
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
/// Generated from GameMember.xlsx sheet member
/// </summary>
public partial class TbGameMember_member
{
    private readonly System.Collections.Generic.Dictionary<int, GameMember_member> _dataMap;
    private readonly System.Collections.Generic.List<GameMember_member> _dataList;
    
    public TbGameMember_member(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, GameMember_member>();
        _dataList = new System.Collections.Generic.List<GameMember_member>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            GameMember_member _v;
            _v = global::HotFix.Cfg.GameMember_member.DeserializeGameMember_member(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, GameMember_member> DataMap => _dataMap;
    public System.Collections.Generic.List<GameMember_member> DataList => _dataList;

    public GameMember_member GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GameMember_member Get(int key) => _dataMap[key];
    public GameMember_member this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

