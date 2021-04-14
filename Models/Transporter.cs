using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tsport.Models
{
    public class Transporter
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public string Destination { get; set; }
        public bool Transporting { get; set; }
        public Transporter()
        {

        }
    }
}
