using System;
using Xamarin.Forms;
using xamarin_sqlite_connect.Models;
using xamarin_sqlite_connect.Settings;

namespace xamarin_sqlite_connect
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            btnSave.Clicked += btnSaveClicked;

            using (var data = new DbAccess())
            {
                lstCostumers.ItemsSource = data.GetAllCustomers();
            }
        }

        protected void btnSaveClicked(object sender, EventArgs e)
        {
            using(var data = new DbAccess())
            {
                data.InsertCustomer(GetCustomer());

                lstCostumers.ItemsSource = data.GetAllCustomers();
            }
        }

        private CustomerModel GetCustomer()
        {
            return new CustomerModel
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhonenumber.Text
            };
        }
    }
}
