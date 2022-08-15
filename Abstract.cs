using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    abstract class Abstract
    {
        
        protected double x = 10;
        protected double y = 20;
        private string AbstractName { get; set; }

        public Abstract(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public abstract double Recatangle();

        public double Nothing()
        {
            return 2 * 5;
        }

        public abstract double price();


    }
}
