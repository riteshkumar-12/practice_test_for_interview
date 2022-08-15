using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class GenricCollections
    {

        //static void Main(string[] args)
        //{
            //    Myprop mypr = new Myprop();
            //    mypr.Number = 15;

            int[] arr = { 1, 8, 4, 5, 12, 2, 5, 6, 7, 1, 90, 100, 56, 8, 34 };

           
            //MessageBox.Show(t.ToString());
            //gf<int> gg = new gf<int>();
            //gg.NAME = "Ritesh";
            //gg.Address = "Patna";

            //GFR testClass = new GFR();
            //testClass.Display<int>("Integer", 34);
            //testClass.Display<string>("String", "string");

            //-------------------------------------------------------------------------


            //Check if an array contain the elements that match the specified conditions

            //string[] array = new string[] { "Ruby", "C", "C++", "Java",
            //                 "Perl", "C#", "Python", "PHP" };

            //int[] array1 = new int[] { 1, 2, 3, 4, 5 };

            //Console.WriteLine("Check if data exists:- {0}", Array.Exists(array, element => element == "Ruby"));

            //Console.WriteLine("Is element start with O letter is present in array: {0}",
            //          Array.Exists(array, element => element.StartsWith("O")));


            //-------------------------------------------------------------------------------------------------------

        //    HashSet<string> hh = new HashSet<string>();
        //    hh.Add("Ritesh");
        //    hh.Add("Ritesh");
        //    hh.Add("Ritesh");


        //    Queue<string> que = new Queue<string>();
        //    que.Enqueue("Ritesh");
        //    que.Enqueue("Kumar");
        //    que.Enqueue("Chaubey");

        //    Queue myQUue = new Queue();

        //    Hashtable has2 = new Hashtable();
        //    has2.Add("Key1", 1);
        //    has2.Add("Key2", 2);
        //    has2.Add("Key3", 3);
        //    has2.Add("Key4", 4);

        //    Stack<string> stack = new Stack<string>();
        //    stack.Push("Ritesh");
        //    stack.Push("Kumar");
        //    stack.Push("Chaubey");

        //    foreach (string item in que)
        //    {
        //        Console.WriteLine(item);
        //    }

        //    foreach (string item in stack)
        //    {
        //        Console.WriteLine(item);
        //    }
        //    // //------------------------------------------------------------------------
        //    Console.ReadLine();
        //}






        public class gf<T>
        {
            public string NAME { get; set; }
            public string Address { get; set; }

        }

        public abstract class Ritesh
        {
            public abstract string MyNAME();
        }

        public class GFR
        {

            public void Display<typeofvalue>(string msg, typeofvalue typeofvalues)
            {
                Console.WriteLine("{0} : {1}", msg, typeofvalues);
            }
        }


        public class Myprop
        {
            private int _number;
            public int Number
            {
                get { return this._number; }


                set
                {
                    if (value > 5)
                    { this._number = 5; }
                    else
                    { this._number = value; }
                }
            }
        }
    }


}
