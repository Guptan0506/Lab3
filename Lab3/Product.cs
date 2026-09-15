using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Product
    {
        public Product() { }

        public Product(string code, string desc, decimal price)
        {
            Code = code;
            Description = desc;
            Price = price;
        }

        public string Code { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
    }
}
