
using Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using static DotNetDesignPatternDemos.SOLID.DependencyInversionPrinciple.Program;
using static System.Console;

namespace DotNetDesignPatternDemos.SOLID.DependencyInversionPrinciple
{
    // hl modules should not depend on low-level; both should depend on abstractions
    // abstractions should not depend on details; details should depend on abstractions

    class Program
    {


        interface IA
        {
            //int a { get; set; }
            void PrintValue();
        }

        public class RiteshTest : IA
        {
            public string Name { get; set; }

            public void PrintValue()
            {
                throw new NotImplementedException();
            }

            //void IA.PrintValue()
            //{
            //    throw new NotImplementedException();
            //}
        }

        public class asasa : RiteshTest
        {

        }

        public class B : IA
        {

            int a = 10;
            string bb = "Ritehs";

            //int IA.a { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            void IA.PrintValue()
            {
                Console.WriteLine("Explicit method called");
            }

            public void AddValue()
            {
                Console.WriteLine("Add value method called");
            }
            public void PrintValue()
            {
                Console.WriteLine("B class PrintValue method");
            }
        }


        public class Apple
        {
            public virtual string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Apple
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }

        public class AbatractCheck : Abstract
        {
            public AbatractCheck(double x, double y) : base(x, y)
            {

            }
            
            public new double Nothing()
            {
                return 2 * 4;
            }

            public override double Recatangle()
            {
                return x * y;
            }
            public static void CallMethod()
            {
                Console.WriteLine("The CallMethod called.");
            }

            public override double price()
            {
                throw new NotImplementedException();
            }
        }
        //static void Main(string[] args)
        //{




        //    AbatractCheck abs = new AbatractCheck(2, 4);
        //    abs.Recatangle();
        //    abs.Nothing();
            

            //IA obj = new B();
            //obj.PrintValue();
            //B bb = new B();
            //bb.PrintValue();
            //Console.WriteLine();
            //Console.ReadLine();

            //string num1 = "3000";
            //string num2 = "4000";

            //int result = int.Parse(num1) + int.Parse(num2);
            //Console.WriteLine(result.ToString());


            //int[] arr1 = { 1, 3, 4, 2, 4, 6, 7, 8 };

            //Array.Sort(arr1);
            //Array.Reverse(arr1);
            //// Determine if any two integers in array sum to given integer////

            //int a = 6;


            //foreach (var item in arr1)
            //{
            //    int curVal = item;
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        if (curVal + arr1[i] == a)
            //        { Console.WriteLine("First Number :- {0} , Second Number:- {1}", curVal.ToString(), arr1[i].ToString()); }
            //    }
            //}

            //    //Determine if any two integers in array sum to given integer///

            //string vv = "1122323345667";
            //var groups = vv.GroupBy(x => x);
            //foreach (var item in groups)
            //{
            //    Console.WriteLine("Values {0} has {1} items", item.Key, item.Count());
            //}
            // Console.ReadLine();
            //    //Console.WriteLine(data);

            //    //B bb = new B();
            //    //bb.
            // }

        }
    }
