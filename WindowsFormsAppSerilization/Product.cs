﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppSerilization
{
    [Serializable]
    public class Product
    {
        public int Id { get; set; }

        public String Name { get; set; }
        public int Price { get; set; }
    }
}
