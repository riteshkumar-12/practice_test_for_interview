using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class y
    {
        static y()
        { Console.WriteLine("Static con called"); }

        public y() { Console.WriteLine("This is fx constructor"); }

        public y(int a) : this()
        {
            Console.WriteLine("THis is overloaded constructor");
        }
    }
    class x { }
    public class IsAndAsDifference
    {
        static void Main(string[] args)
        {
            y dd = new y(2);
            object[] o = new object[5];
            o[0] = new y();
            o[1] = new x();
            o[2] = 12;
            o[3] = false;
            o[4] = "Ritesh";

            foreach (object item in o)
            {
                object s1 = item as string;
                if (s1 == null)
                    Console.WriteLine("It is string");
                else
                    Console.WriteLine("The class converted to string:- {0}", s1);
                Console.ReadLine();
            }
        }
    }
}
