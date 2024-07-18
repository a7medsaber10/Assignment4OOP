using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP.Interfaces
{
    internal interface ISeries
    {
        // 1. Signature for Property    
        public int Current { get; set; }

        // 2. Signature for method
        public void GetNext();

        // 3. Default emplemented method
        public void Reset()
        {
            Current = 0;
        }

    }
}
