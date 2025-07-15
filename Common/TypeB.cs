using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TypeB
    {
        private  int  X;
        internal int  Y;
        public   int  Z;
        void fun01()
        {
            TypeA TypeA = new TypeA();
            TypeB TypeB = new TypeB();
            TypeB.X = 12;
            TypeB.Y = 13;
            TypeB.Z = 14;
        }
      
    }
}
