﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Destination
    {

        public int DestinationId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }

        public byte[] photo { get; set; }

        public List<Lodging> Lodgings { get; set; }

    }
}