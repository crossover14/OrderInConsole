using System;
using System.Collections.Generic;
using System.Text;

namespace _Order_Estudo.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Prince { get; set; }

        public Product()
        {
        }

        public Product(string name, double prince)
        {
            Name = name;
            Prince = prince;
        }
    }
}
