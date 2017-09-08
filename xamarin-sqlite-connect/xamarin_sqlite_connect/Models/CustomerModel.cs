using SQLite.Net.Attributes;

namespace xamarin_sqlite_connect.Models
{
    class CustomerModel
    {
        private int _id;

        [PrimaryKey, AutoIncrement]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        private string _phoneNumber;

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0} | E-mail: {1}", Name, Email);
        }
    }
}
