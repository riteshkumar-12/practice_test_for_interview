using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Out_Ref_Practice
    {
        //These two keywords helps to pass variables by reference to function and methods

        // In ref one passes the data and address from caller to calle and manipulated 
        //data is again passed back

        //In out he passes the refernce only from the caller to calle and only amnipulated data 
        //goes out to the caller.
        //Also in out we have to reiniliatized the variable inside the calle function.
        //static void Main(string[] args)
        //{

        //    string _name = "RiteshKumar";

        //    int length = _name.Length;

        //    Array hasToConvertName = _name.ToCharArray();



        //Fraction frac = new Fraction { Denominator = 1, Numerator = 2 };

        //int insideVal = 20;
        //int outVal2, Sum2;
        //SomeFunction(out outVal2, out Sum2);
        //SomeFunction2(ref insideVal);

        //  }

        //In below fucntion we didn't even define the return type of the method but still returning the values.

        private static void SomeFunction(out int outVal, out int Sum)
        {
            outVal = 0;
            Sum = 20;
            Sum = Sum + 20;
            outVal = outVal + 10;
        }


        private static void SomeFunction2(ref int insideVal)
        {
            insideVal = insideVal + 20;
        }


        class Fraction
        {
            public int Numerator;
            public int Denominator;
        }

    }
}
