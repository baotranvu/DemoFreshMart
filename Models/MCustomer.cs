using System;
using System.Reflection;
using System.Security.Cryptography;

namespace Models
{
    
    public class MCustomer : Person
    {
        public string password { get; private set; }  
        public string Rank { get; }     
        public decimal Point { get; }
        public MCustomer()
        {
            MAccount account = new MAccount();
            this.Email = account.Usename;
            account.Password = account.ComputeHash(this.password, new SHA256CryptoServiceProvider());
        }


    }
}
