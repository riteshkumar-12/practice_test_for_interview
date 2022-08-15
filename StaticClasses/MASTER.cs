using Practice.StaticClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Master
    {
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        //Made ComputerName propert to puclic so that it can be accessed;
        private string ComputerName
        {
            get
            {
                return CommonRoutines.ComputerName();
            }
        }
        public void Insert()
        { }


    }
}
