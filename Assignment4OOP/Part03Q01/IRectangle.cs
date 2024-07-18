using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP.Part03Q01
{
    internal interface IRectangle : IShape
    {
        double Width { get; } 
        double Height { get; }
    }
}
