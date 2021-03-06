﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASS1.Models
{
    public class Orderitem
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int HatID { get; set; }
        public int OrderID { get; set; }
        public string Quantity { get; set; }

        public virtual Hat Hat { get; set; }
        public virtual Order Order { get; set; }
    }
}
