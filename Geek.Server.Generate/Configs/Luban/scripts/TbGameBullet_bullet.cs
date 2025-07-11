
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
/// Generated from GameBullet.xlsx sheet bullet
/// </summary>
public partial class TbGameBullet_bullet
{
    private readonly System.Collections.Generic.Dictionary<int, GameBullet_bullet> _dataMap;
    private readonly System.Collections.Generic.List<GameBullet_bullet> _dataList;
    
    public TbGameBullet_bullet(ByteBuf _buf)
    {
        _dataMap = new System.Collections.Generic.Dictionary<int, GameBullet_bullet>();
        _dataList = new System.Collections.Generic.List<GameBullet_bullet>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            GameBullet_bullet _v;
            _v = global::HotFix.Cfg.GameBullet_bullet.DeserializeGameBullet_bullet(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.id, _v);
        }
    }

    public System.Collections.Generic.Dictionary<int, GameBullet_bullet> DataMap => _dataMap;
    public System.Collections.Generic.List<GameBullet_bullet> DataList => _dataList;

    public GameBullet_bullet GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public GameBullet_bullet Get(int key) => _dataMap[key];
    public GameBullet_bullet this[int key] => _dataMap[key];

    public void ResolveRef(Tables tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
    }

}

}

