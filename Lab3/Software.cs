using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    public class Software : Product
    {
        public Software() { }

        public Software(string code, string desc, decimal price, string company) : base(code, desc, price)
        {
            Company = company;
        }

        public string Company { get; set; }

        public override string GetDisplayText(string sep)
        {
            return base.GetDisplayText(sep) + sep + $"{Company}";
        }
    }
}