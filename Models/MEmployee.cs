using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    
    public class MEmployee : Person
    {
        public string password { get; private set; }
        public MEmployee()
        {
            MAccount account = new Models.MAccount();
            account.Usename = this.Name;
            account.Password = this.password;
        }
    }
}
