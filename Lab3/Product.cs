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

        public virtual string GetDisplayText(string sep)
        {
            // returns a string in the following order but since price is a 
            // decimal it needs to be converted to string in currency format.
            return $"{Code}{sep}{Description}{sep}{Price.ToString("c")}";
        }
    }
}
