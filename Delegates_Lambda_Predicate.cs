using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Delegates_Lambda_Predicate
    {

        delegate double CalArePointer(int r);

        //static void Main(string[] args)
        //{

        //}

        static double CalculateArea(int r)
        {
            return 3.14 * r * r;
        }
    }
}
