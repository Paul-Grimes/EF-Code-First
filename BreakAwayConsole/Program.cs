﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DataAccess;

namespace BreakAwayConsole
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static void InsertDestination()
        {
            var destination = new Destination
            {
                Country = "Indonesia",
                Description = "EcoTourism at its best in exotic Bali",
                Name = "Bali"
            };
        }
    }
}