using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThienNguyen.DTO
{
    internal class Account
    {
        private string _id;
        private string _username;
        private string _password;

        public Account(string user, string pass) 
        {
            this.Username = user;
            this.Password = pass;
        }
        public string Id { get => _id; set => _id = value; }
        public string Username { get => _username; set => _username = value; }
        public string Password { get => _password; set => _password = value; }
    }
}
