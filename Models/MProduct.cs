using System;


namespace Models
{
    public class MProduct : Object
    {
        public DateTime MFG { get; set; }
        public DateTime EXP { get; set; }
        public string Type { get; set; }
        public string Unit { get; set; }
        public int Discount { get; set; }
        public decimal UnitPrice { get; set; }
        public int Instock { get;}
    }
}
