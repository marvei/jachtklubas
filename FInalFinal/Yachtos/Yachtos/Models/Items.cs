﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Yachtos.Models
{
    public class Items
    {
        public int id { get; set; }
        public Storage fk_storage { get; set; }

        public double price { get; set; }

    }
}
