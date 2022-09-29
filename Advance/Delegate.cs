using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance
{
    public delegate  int math(int x, int y);
    internal class Delegate1
    {
        public int add(int x, int y) 
        {
            return x + y;   
        }

        public int sub(int x, int y) 
        {
            return x - y;    
        }

        public int divide(int x, int y) 
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            else 
            {
                return x / y;    
            }
        }

        public int multiply(int x, int y) 
        {
            return x * y;
        }
    }
}
