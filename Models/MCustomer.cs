
using System.Security.Cryptography;

namespace Models
{
    using Framework;
   
    
    public class MCustomer : Bindable
    {
        
        public string ID { get;}
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string password { get; private set; }  
        
        public MCustomer()
        {
            
            MAccount account = new MAccount();
            account.Usename = this.Email;
            account.Password = account.ComputeHash(this.password, new SHA256CryptoServiceProvider());
        }


    }
}
