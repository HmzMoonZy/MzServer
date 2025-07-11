
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
/// Generated from Mining.xlsx sheet bonusGame
/// </summary>
public partial class TbMining_bonusGame
{
    private readonly System.Collections.Generic.Dictionary<int, Mining_bonusGame> _dataMap;
    private readonly System.Collections.Generic.List<Mining_bonusGame> _dataList;
    
    public TbMining_bonusGame(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Mining_bonusGame>();
        _dataList = new System.Collections.Generic.List<Mining_bonusGame>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Mining_bonusGame _v;
            _v = global::HotFix.Cfg.Mining_bonusGame.DeserializeMining_bonusGame(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Mining_bonusGame> DataMap => _dataMap;
    public System.Collections.Generic.List<Mining_bonusGame> DataList => _dataList;

    public Mining_bonusGame GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Mining_bonusGame Get(int key) => _dataMap[key];
    public Mining_bonusGame this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

