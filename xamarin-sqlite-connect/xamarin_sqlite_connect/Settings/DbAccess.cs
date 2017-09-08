using SQLite.Net;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xamarin.Forms;
using xamarin_sqlite_connect.Models;

namespace xamarin_sqlite_connect.Settings
{
    class DbAccess : IDisposable
    {
        private SQLiteConnection connection;

        public DbAccess()
        {
            var setting = DependencyService.Get<IDbSetting>();

            connection = new SQLiteConnection(setting.Platform, Path.Combine(setting.PathDB, "DbApp.db3"));
            connection.CreateTable<CustomerModel>();
        }        

        public void InsertCustomer(CustomerModel customer)
        {
            connection.Insert(customer);
        }

        public List<CustomerModel> GetAllCustomers()
        {
            return connection.Table<CustomerModel>().OrderBy(c => c.Name).ToList();
        }

        public void Dispose()
        {
            connection.Close();
        }
    }
}
