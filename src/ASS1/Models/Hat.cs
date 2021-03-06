﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASS1.Models
{
    public class Hat
    {
        public int HatID { get; set; }
        public string SupplierID { get; set; }
        public string CategoryID { get; set; }
        public string HatName { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public virtual Supplier Supplier { get; set; }
        public virtual Category Category { get; set; }
    }
}
