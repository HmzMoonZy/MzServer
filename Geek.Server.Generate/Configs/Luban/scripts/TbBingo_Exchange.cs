
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
/// Generated from Bingo.xlsx sheet Exchange
/// </summary>
public partial class TbBingo_Exchange
{
    private readonly System.Collections.Generic.Dictionary<int, Bingo_Exchange> _dataMap;
    private readonly System.Collections.Generic.List<Bingo_Exchange> _dataList;
    
    public TbBingo_Exchange(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Bingo_Exchange>();
        _dataList = new System.Collections.Generic.List<Bingo_Exchange>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Bingo_Exchange _v;
            _v = global::HotFix.Cfg.Bingo_Exchange.DeserializeBingo_Exchange(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Bingo_Exchange> DataMap => _dataMap;
    public System.Collections.Generic.List<Bingo_Exchange> DataList => _dataList;

    public Bingo_Exchange GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Bingo_Exchange Get(int key) => _dataMap[key];
    public Bingo_Exchange this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

