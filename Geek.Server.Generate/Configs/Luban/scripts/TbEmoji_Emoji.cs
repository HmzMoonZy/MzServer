
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
/// Generated from Emoji.xlsx sheet Emoji
/// </summary>
public partial class TbEmoji_Emoji
{
    private readonly System.Collections.Generic.Dictionary<int, Emoji_Emoji> _dataMap;
    private readonly System.Collections.Generic.List<Emoji_Emoji> _dataList;
    
    public TbEmoji_Emoji(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, Emoji_Emoji>();
        _dataList = new System.Collections.Generic.List<Emoji_Emoji>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            Emoji_Emoji _v;
            _v = global::HotFix.Cfg.Emoji_Emoji.DeserializeEmoji_Emoji(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, Emoji_Emoji> DataMap => _dataMap;
    public System.Collections.Generic.List<Emoji_Emoji> DataList => _dataList;

    public Emoji_Emoji GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public Emoji_Emoji Get(int key) => _dataMap[key];
    public Emoji_Emoji this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

