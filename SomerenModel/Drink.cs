﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Drink
    {
        public int DrinkId { get; set; }
        public string DrinkName { get; set; }
        public int Price { get; set; }

        public bool Is_Alchol { get; set; }
        public int Stock { get; set; }
    }
}
