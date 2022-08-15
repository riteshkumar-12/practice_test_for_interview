using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DotNetDesignPatternDemos.Creational.Singleton
{

    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;

        //public static Singleton GetInstance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new Singleton();
        //        return instance;
        //    }
        //}

        public static Singleton GetInstance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;

            }


        }


        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }

        public void PrintDetails()
        {
            Console.WriteLine("PrintDetails Method Called");
        }

        public static void Testing()
        {
            int i = 200;

        }
    }


    public static class HistoryTeacher
    {
        private static string Name;
        private static string Address;
    }
    class Example
    {

        int x = 100;
        static int y = 200;
        static void Add()
        {
            Example obj = new Example();
            //Console.WriteLine(obj.x + Example.y);
            Console.WriteLine("Sum of 100 and 200 is :" + (obj.x + y));
        }
        void Mul()
        {
            Console.WriteLine("Multiplication of 100 and 200 is :" + (this.x * Example.y));
            Console.WriteLine("Multiplication of 100 and 200 is :" + (x * y));
        }

        public abstract class Fruit
        {
            public abstract string GetColor();
        }
        public class Apple : Fruit
        {
            public override string GetColor()
            {
                return "Red";
            }
        }
        public class Orange : Fruit
        {
            public override string GetColor()
            {
                return "Orange";
            }
        }


        static void print2largest(int[] arr,
                          int arr_size)
        {
            int i;

            // There should be 
            // atleast two elements
            if (arr_size < 2)
            {
                Console.Write(" Invalid Input ");
                return;
            }

            // Sort the array
            Array.Sort(arr);

            // Start from second last element
            // as the largest element is at last
            for (i = arr_size - 2; i >= 0; i--)
            {

                // If the element is not
                // equal to largest element
                if (arr[i] != arr[arr_size - 1])
                {
                    Console.Write("The second largest " +
                                  "element is {0}\n", arr[i]);
                    return;
                }
            }

            Console.Write("There is no second " +
                          "largest element\n");
        }

        //static void Main(string[] args)
        //{
        //    int[] arr = { 12, 35, 1, 10, 34, 1 };
        //    int n = arr.Length;
        //    print2largest(arr, n);
        //int m, count = 0;
        //Console.WriteLine("Enter the Limit : ");
        //m = int.Parse(Console.ReadLine());
        //int[] a = new int[m];
        //Console.WriteLine("Enter the Numbers :");
        //for (int i = 0; i < m; i++)
        //{
        //    a[i] = Convert.ToInt32(Console.ReadLine());
        //}
        //foreach (int o in a)
        //{
        //    if (o == 1)
        //    {
        //        count++;
        //    }
        //}
        //Console.WriteLine("Number of 1's in the Entered Number : ");
        //Console.WriteLine(count);
        //Console.ReadLine();
        //---------------------------------------------
        //int p, lastInt = 0, input;
        //Console.WriteLine("Enter the Number of Rows : ");
        //input = int.Parse(Console.ReadLine());
        //for (int i = 1; i <= input; i++)
        //{
        //    for (p = 1; p <= i; p++)
        //    {
        //        if (lastInt == 1)
        //        {
        //            Console.Write("0");
        //            lastInt = 0;
        //        }
        //        else if (lastInt == 0)
        //        {
        //            Console.Write("1");
        //            lastInt = 1;
        //        }
        //    }
        //    Console.Write("\n");
        //}
        //Console.ReadLine();

        //---------------------------------------------------------------
        //int num, reverse = 0;
        //Console.WriteLine("Enter a Number : ");
        //num = int.Parse(Console.ReadLine());
        //while (num != 0)
        //{
        //    reverse = reverse * 10;
        //    reverse = reverse + num % 10;
        //    num = num / 10;
        //}
        //Console.WriteLine("Reverse of Entered Number is : " + reverse);
        //Console.ReadLine();

        //-------------------------------------------------------
        //int num, sum = 0, r;
        //Console.WriteLine("Enter a Number : ");
        //num = int.Parse(Console.ReadLine());
        //while (num != 0)
        //{
        //    r = num % 10;
        //    num = num / 10;
        //    sum = sum + r;
        //}
        //Console.WriteLine("Sum of Digits of the Number : " + sum);
        //Console.ReadLine();

        //---------------------------------------------------------------------
        //String a = "Hello";
        //String b = "Geeks";
        //Console.WriteLine("Strings before swap: a =" +
        //                  " " + a + " and b = " + b);
        //a = a + b;
        //b = a.Substring(0, a.Length - b.Length);
        //a = a.Substring(b.Length);
        //Console.WriteLine("Strings after swap: a =" +
        //                  " " + a + " and b = " + b);
        //-------------------------------------------------------------------
        //Example.Add();
        //Add();

        //-----------------------------
        //------------------ pythagorus theorem
        //double a = 2;
        //double b = 3;

        //double side = Math.Sqrt(a * a + b * b);
        //Console.WriteLine(side);
        //Console.ReadLine();
        //----------------------------------------
        //int[] a = { 1, 2, 4, 5, 6 };
        //int miss = getMissingNo(a, 5);
        //Console.Write(miss);
        //Fruit fruit = new Orange();
        //Console.WriteLine(fruit.GetColor());
        //fruit = new Apple();
        //Console.WriteLine(fruit.GetColor());
        //Singleton single = Singleton.GetInstance;
        //single.PrintDetails();
        //Singleton singleTwo = Singleton.GetInstance;
        //singleTwo.PrintDetails();

        // }

        static int getMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
                total -= a[i];

            return total;
        }
    }
}
