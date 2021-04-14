using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tsport.Models
{
    public class  Order
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public bool CautionRequired { get; set; }
        public Order()
        {

        }
    }
}
