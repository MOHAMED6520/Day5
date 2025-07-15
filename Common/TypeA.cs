using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class TypeA
    {
        void Fun01()
            { 
                TypeA typeA = new TypeA();
                TypeB typeB = new TypeB();

               // typeB.x = 5; //invalid
                typeB.Y = 6;
                typeB.Z = 7;
            }
    }
}
