using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Vlaue_Refernce_Type
    {
        public int value { get; set; }

        public Vlaue_Refernce_Type(int passByRef)
        {
            this.value = passByRef;
        }

    }

    class progrME
    {

        struct A
        {
            public int val { get; set; }
        }
        //static void Main(string[] args)
        //{
        //    //Examples of Refernce type are Classes,Objects, Arrays, Strings, Interfaces.

            //Vlaue_Refernce_Type val = new Vlaue_Refernce_Type(3);
            //Vlaue_Refernce_Type val2 = new Vlaue_Refernce_Type(5);
            //val2 = val;
            //Console.WriteLine(val.value);
            //Console.WriteLine(val2.value);

            //Vlaue_Refernce_Type val3 = new Vlaue_Refernce_Type(10);
            //int v1 = 12;
            //int v2 = 13;
            //v2 = v1;
            //Console.WriteLine(v2);
            //Console.ReadLine();


        //    A v1 = new A();
        //    v1.val = 10;
        //    method1(v1);
        //    Console.WriteLine(v1);
        //    Console.ReadLine();

        //}

        private static void method1(A obj)
        {
            obj = new A();
        }
    }

}
