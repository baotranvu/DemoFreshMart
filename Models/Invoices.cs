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
    
    public partial class Invoices
    {
        public Invoices()
        {
            this.Invoice_detail = new HashSet<Invoice_detail>();
        }
    
        public int InvIntID { get; set; }
        public string InvID { get; set; }
        public string EmpID { get; set; }
        public System.DateTime Date { get; set; }
        public decimal Total { get; set; }
        public decimal Cash { get; set; }
    
        public virtual Employees Employees { get; set; }
        public virtual ICollection<Invoice_detail> Invoice_detail { get; set; }
    }
}
