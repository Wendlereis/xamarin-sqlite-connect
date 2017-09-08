using SQLite.Net.Interop;
using SQLite.Net.Platform.XamarinAndroid;
using System;
using Xamarin.Forms;
using xamarin_sqlite_connect.Droid.Settings;
using xamarin_sqlite_connect.Settings;

[assembly: Dependency(typeof(DbSetting))]
namespace xamarin_sqlite_connect.Droid.Settings
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
                    _pathDB = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
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
                    _platform = new SQLitePlatformAndroid();
                }

                return _platform;
            }
        }
    }
}