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
    
    public partial class Products
    {
        public int SKUInt { get; set; }
        public string SKU { get; set; }
        public string Product { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        public double UnitPrice { get; set; }
        public Nullable<System.DateTime> MFG { get; set; }
        public Nullable<System.DateTime> EXP { get; set; }
        public decimal InStock { get; set; }
        public Nullable<decimal> Discount { get; set; }
    }
}
