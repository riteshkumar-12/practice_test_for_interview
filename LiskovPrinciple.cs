using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class LiskovPrinciple
    {
        //static void Main(string[] args)
        //{
        //    //Fruits APP = new Orange();
        //    //string Color = APP.GetColor();

        //}
    }

    public abstract class Fruits
    {
        public abstract string GetColor();
    }


    //public class Apple : Fruits
    //{
    //    public override string GetColor()
    //    {
    //        return "RED";
    //    }

    //}

    //public class Orange : Fruits
    //{
    //    public override string GetColor()
    //    {
    //        return "ORANGE";
    //    }
    //}
    public class X
    {
        public virtual void A()
        {
        }
    }
    public class Y : X
    {
        public override void A()
        {
        }
    }

    public class Z : Y
    {
        public override void A()
        {
        }
    }

}
