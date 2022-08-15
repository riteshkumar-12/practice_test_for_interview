using System.Linq;

namespace Practice.StaticClasses
{
    class SomeApplication
    {
        //static void Main(string[] args)
        //{
            //Customer oCustomer = new Customer();
            //Master oMaster = new Master();

            //-------------------------------------------------
            //int sum = 8;
            //int[] arry1 = new int[] { 1, 2, 4, 4 };

            //HasPairOfSum(arry1, sum);
            //----------------------------------------------------
        //}


        //-------------------------------------------------------
        //Test that array has the pair to get the sum of 8 
        public static bool HasPairOfSum(int[] array1, int sum)
        {
            bool hasPair = false;
            int low = 0;
            int high = array1.Length - 1;
            int high2 = array1.Length;
            while (low < high)
            {
                if (array1[low] + array1[high] == sum)
                {
                    return hasPair = true;
                }
                else
                {
                    low++;
                }
            }
            //-------------------------------------------------------------

            return hasPair;

        }
    }
}
