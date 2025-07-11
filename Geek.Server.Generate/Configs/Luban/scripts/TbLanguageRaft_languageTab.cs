
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
/// Generated from LanguageRaft.xlsx sheet languageTab
/// </summary>
public partial class TbLanguageRaft_languageTab
{
    private readonly System.Collections.Generic.Dictionary<int, LanguageRaft_languageTab> _dataMap;
    private readonly System.Collections.Generic.List<LanguageRaft_languageTab> _dataList;
    
    public TbLanguageRaft_languageTab(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, LanguageRaft_languageTab>();
        _dataList = new System.Collections.Generic.List<LanguageRaft_languageTab>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            LanguageRaft_languageTab _v;
            _v = global::HotFix.Cfg.LanguageRaft_languageTab.DeserializeLanguageRaft_languageTab(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, LanguageRaft_languageTab> DataMap => _dataMap;
    public System.Collections.Generic.List<LanguageRaft_languageTab> DataList => _dataList;

    public LanguageRaft_languageTab GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public LanguageRaft_languageTab Get(int key) => _dataMap[key];
    public LanguageRaft_languageTab this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

