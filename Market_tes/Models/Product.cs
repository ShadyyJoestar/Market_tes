using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Market_tes.Models
{
    internal class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public string Category { get; set; }
        public Decimal Price { get; set; }
        public int stock { get; set; }
    }
}
