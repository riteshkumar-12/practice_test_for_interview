using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Constant_Readonly
    {
        //you cannot apply static keyword with const keyword
        public const int cmToMteters = 100; // compile time contant. It's stored inside the IL code itself
        public static readonly double PI = 3.14; // Runtime Constant;
        //static void Main(string[] args)
        //{

        //}
    }
}
