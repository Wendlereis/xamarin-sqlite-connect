using SQLite.Net.Interop;

namespace xamarin_sqlite_connect.Settings
{
    public interface IDbSetting
    {
        string PathDB { get; }
        ISQLitePlatform Platform { get; }
    }
}
