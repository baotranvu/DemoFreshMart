using System;

namespace Models
{
    public class Object
    {
        public string ID { get; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string CreatorID { get; set; }
        
    }
}
