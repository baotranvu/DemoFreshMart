using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    class MProduct : Object
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
