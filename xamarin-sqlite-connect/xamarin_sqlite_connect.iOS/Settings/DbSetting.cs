using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinIOS;
using System;
using System.IO;
using Xamarin.Forms;
using xamarin_sqlite_connect.iOS.Settings;
using xamarin_sqlite_connect.Settings;

[assembly: Dependency(typeof(DbSetting))]
namespace xamarin_sqlite_connect.iOS.Settings
{
    class DbSetting : IDbSetting
    {
        private string _pathDB;
        public string PathDB
        {
            get
            {
                if (string.IsNullOrEmpty(_pathDB))
                {
                   var dir = Environment.GetFolderPath(Environment.SpecialFolder.Personal);

                    _pathDB = Path.Combine(dir, "..", "Library");
                }

                return _pathDB;
            }
        }

        private ISQLitePlatform _platform;
        public ISQLitePlatform Platform
        {
            get
            {
                if (_platform == null)
                {
                    _platform = new SQLitePlatformIOS();
                }

                return _platform;
            }
        }
    }
}
