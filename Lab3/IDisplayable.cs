using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3
{
    // Naming Convention use I before names of interfaces
    public interface IDisplayable
    {
        // We don't tell it what it will output we just tell it what parameters it takes
        string GetDisplayString(string sep);
    }
}
