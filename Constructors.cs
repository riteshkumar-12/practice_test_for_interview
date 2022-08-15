using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Constructors
    {
        public Constructors()
        {
            IniliazeName();
        }

        static Constructors()
        {

        }
        //static void Main(string[] args)
        //{
        //    Constructors _ct = new Constructors();

        //}
        public string IniliazeName()
        {
            return "Ritesh";
        }



    }


    public static class CallingConstructors
    {
        static CallingConstructors()
        {

        }
        // Constructors _ct = new Constructors();
    }


     
}
