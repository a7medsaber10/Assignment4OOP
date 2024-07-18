using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4OOP.InterfaceEx02
{
    internal class Airplane : Vechle, IMovable, IFlyable
    {
        // if Forward() and Backward() are the same implementation => implicitly

        // if Forward() and Backward() have different implementation => explicitly

        void IMovable.Backward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Backward()
        {
            throw new NotImplementedException();
        }

        void IMovable.Forward()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Forward()
        {
            throw new NotImplementedException();
        }
    }
}
