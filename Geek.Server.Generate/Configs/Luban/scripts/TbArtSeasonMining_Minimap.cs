
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
/// Generated from ArtSeasonMining.xlsx sheet Minimap
/// </summary>
public partial class TbArtSeasonMining_Minimap
{
    private readonly System.Collections.Generic.Dictionary<int, ArtSeasonMining_Minimap> _dataMap;
    private readonly System.Collections.Generic.List<ArtSeasonMining_Minimap> _dataList;
    
    public TbArtSeasonMining_Minimap(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, ArtSeasonMining_Minimap>();
        _dataList = new System.Collections.Generic.List<ArtSeasonMining_Minimap>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            ArtSeasonMining_Minimap _v;
            _v = global::HotFix.Cfg.ArtSeasonMining_Minimap.DeserializeArtSeasonMining_Minimap(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, ArtSeasonMining_Minimap> DataMap => _dataMap;
    public System.Collections.Generic.List<ArtSeasonMining_Minimap> DataList => _dataList;

    public ArtSeasonMining_Minimap GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public ArtSeasonMining_Minimap Get(int key) => _dataMap[key];
    public ArtSeasonMining_Minimap this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

