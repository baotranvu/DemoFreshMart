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
    
    public partial class Employees
    {
        public Employees()
        {
            this.Invoices = new HashSet<Invoices>();
        }
    
        public int EmpIntID { get; set; }
        public string EmpID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public System.DateTime Date { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    
        public virtual ICollection<Invoices> Invoices { get; set; }
    }
}
