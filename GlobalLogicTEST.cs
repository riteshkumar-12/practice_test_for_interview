using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class GlobalLogicTEST
    {
        public GlobalLogicTEST()
        {
            Console.WriteLine("Class A called");
        }
        public void TestingMethod()
        { Console.WriteLine("Method in A called"); }
    }

    public class B : GlobalLogicTEST
    {
        public B()
        {
            Console.WriteLine("Class B constructor called");
        }

        public new void TestingMethod()
        { Console.WriteLine("Method in B called"); }
    }

    public class Mains
    {
        //static void Main(string[] args)
        //{
        //    GlobalLogicTEST _global = new B();
        //    _global.TestingMethod();
        //   // B _b = new B();
            
        //    Console.ReadLine();
            
        //}
    }
}
