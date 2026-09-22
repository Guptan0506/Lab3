using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    // Book : Product means that Book class is inheriting from Product class
    public class Book : Product, IDisplayable
    {
        public string Author { get; set; }

        public Book() { }
        
        public Book(string code, string desc, decimal price, string author) : base(code, desc, price)
        {
            Author = author;
        }

        public override string GetDisplayText(string sep)
        {
            // Concatenates Author to the existing text
            return base.GetDisplayText(sep) + sep + $"{Author}";
        }

        public string GetDisplayString(string sep)
        {
            return base.GetDisplayText(sep) + sep + $"{Author}";
        }
    }
}
