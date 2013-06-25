using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Lodging
    {
        public int LodgingId { get; set; }

        public string name { get; set; }
        public string owner { get; set; }
        public bool isResort { get; set; }

        public Destination destination { get; set; }
    }
}
