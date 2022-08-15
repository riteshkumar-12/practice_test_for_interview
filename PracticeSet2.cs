using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practice
{
    class PracticeSet2
    {

        //static void Main(string[] args)
        //{
        //    int[] a = { 1, 2, 4, 5, 6 };
        //    int miss = getMissingNo(a, 5);

            //-----------------------------------------------------
            //string stringInput = "RITESHKMAR";
            //char[] stringArray = stringInput.ToCharArray();

            //string reverse = String.Empty;

            //for (int i = stringArray.Length - 1; i >= 0; i--)
            //{
            //    reverse += stringArray[i];
            //}

            //-----------------------------------------------------------

            //int[] arr = { 10, 324, 45, 90, 9808 };
            //int i;

            //// Initialize maximum element
            //int max = arr[0];

            //// Traverse array elements from second and
            //// compare every element with current max
            //for (i = 1; i < arr.Length; i++)
            //    if (arr[i] > max)
            //        max = arr[i];

            //--------------------------------------------------------


            //-----------------------------------------------------------------

            //int[] myArray = new int[] { 0, 1, 2, 3, 13, 8, 5 };
            //int highest = (from number in myArray orderby number descending select number).Distinct().Skip(2).FirstOrDefault();
            //Console.WriteLine(highest);
            //int _highest = (from number in myArray orderby number descending select number).Distinct().Skip(2).FirstOrDefault();
            //-----------------------------------------------
            //Factorial of number

            //int number = 5;
            //int factorial = 1;
            //for (int i = 1; i < number; i++)
            //{
            //    factorial = factorial * i;
            //}
            //Console.WriteLine(factorial);


            //------------------------------------------------------
            //programme to check if number is palindrom

            //Console.Write("Enter a Number To Check Palindrome : ");
            //int number = int.Parse(Console.ReadLine());
            //int remineder, sum = 0;
            //int temp = number;
            //while (number > 0)
            //{
            //    remineder = number % 10;
            //    sum = (sum * 10) + remineder;
            //    number = number / 10;
            //}
            //if (temp == sum)
            //{
            //    Console.WriteLine($"Number {temp} is Palindrome.");
            //}
            //else
            //{
            //    Console.WriteLine($"Number {temp} is not Palindrome");
            //}


            //----------------------------------------------

            //---------------------------------------
            //checks whether the string is palindrom or not
            //----------------- 1 way------------------
            //string name = "ABCBA";
            //char[] nameArray = name.ToCharArray();

            //string reverse = string.Empty;
            //for (int i = nameArray.Length - 1; i >= 0; i--)
            //{
            //    reverse += nameArray[i].ToString();
            //}
            //-----------------2 Way ------------------------------
            //Array.Reverse(nameArray);
            //string reverse = new string(nameArray);

            //if (name.Equals(reverse, StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("String is palindrom");
            //}
            //else { Console.WriteLine("String is not palindrom"); }
            //Console.ReadLine();

            //-------------------------------------------------------

            //Given a string, s, find the longest palindromic substring in s. A question by twitter.

            //        string s = "tracecars";
            //        char[] reverseString = s.ToCharArray();
            //        Array.Reverse(reverseString);
            //            string reverse = new string(reverseString);
            //        char[] newReverse = s.ToCharArray();
            //        string longestPallindrom = string.Empty;
            //            for (int i = 0; i<reverseString.Length; i++)
            //            {
            //                if (newReverse[i].Equals(reverseString[i]))
            //                {
            //                    longestPallindrom += reverseString[i].ToString();
            //    }

            //}
            //Console.WriteLine(longestPallindrom);
            //            Console.ReadLine();

            //----------------------------------------
            //Remove duplicates from the string

            //string test = "wwwteessting";
            //var distinct = test.ToCharArray().Distinct().ToArray();
            //var rsltstring = new string(distinct);
            //Console.WriteLine(rsltstring);

            //----------------------------------------------


            //------------------------------------
            //string bb = "ritesh";
            //string cc = "kumar";

            //string s3 = string.Concat(bb, cc);
            ////------------------------------------

            //string s1;
            //Console.WriteLine("Enter the String : ");
            //s1 = Console.ReadLine();
            //Console.WriteLine(counting.CountStringOccurrences(s1, "is"));


            //-------------------------------------------------------------

            //get the no of vowels and no of constants in string

            //char[] sentence = new char[100];

            //int i, vowels = 0, consonants = 0, special = 0, n;
            //Console.WriteLine("Enter the Length of the sentence  \n");
            //n = int.Parse(Console.ReadLine());
            //for (i = 0; i < n; i++)
            //{
            //    sentence[i] = Convert.ToChar(Console.Read());
            //    //strarray[i] = Convert.ToString(Console.Read());

            //}
            //for (i = 0; sentence[i] != '\0'; i++)
            //{
            //    if ((sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] ==
            //    'i' || sentence[i] == 'o' || sentence[i] == 'u') ||
            //    (sentence[i] == 'A' || sentence[i] == 'E' || sentence[i] ==
            //    'I' || sentence[i] == 'O' || sentence[i] == 'U'))
            //    {
            //        vowels = vowels + 1;
            //    }
            //    else
            //    {
            //        consonants = consonants + 1;
            //    }
            //    if (sentence[i] == 't' || sentence[i] == '\0' || sentence[i] == ' ')
            //    {
            //        special = special + 1;
            //    }
            //}

            //consonants = consonants - special;
            //Console.WriteLine("No. of vowels {0}", vowels);
            //Console.WriteLine("No. of consonants {0}", consonants);
            //Console.ReadLine();
            //----------------------------------------------------------
            //    Console.ReadLine();
            //}


            //int[] myArray = new int[] { 0, 11, 2, 15, 16, 8, 16, 8, 15 };
            //int Smallest = myArray.Min();
            //int Largest = myArray.Max();
            //foreach (int i in myArray)
            //{
            //    if (i > Smallest && i < Largest)
            //    {
            //        Smallest = i;
            //    }
            //}
            //System.Console.WriteLine(Smallest);
            //Console.ReadLine();

            //----------------------------------------------
            //method to find frequency of string in sentence 
            //Console.WriteLine(miss);
            //Console.ReadLine();
           


            //}


       // }
        static int getMissingNo(int[] a, int n)
        {
            int total = (n + 1) * (n + 2) / 2;

            for (int i = 0; i < n; i++)
                total -= a[i];

            return total;
        }


        public static class counting
        {
            public static int CountStringOccurrences(string text, string pattern)
            {

                int count = 0;
                int i = 0;
                while ((i = text.IndexOf(pattern, i)) != -1)
                {
                    i += pattern.Length;
                    count++;
                }
                return count;
            }


        }


        //--------------------------------------------------------
    }
}
