//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customers
    {
        public int CusIntID { get; set; }
        public string CusID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public System.DateTime Birth { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    
        public virtual Account Account { get; set; }
    }
}
