using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StaticClasses
{
    public class Customer
    {
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        private string MachineName = "";

        public Customer()
        {
            MachineName = CommonRoutines.ComputerName();
        }
        //made the IsEmpty method public from private. So that we can access it.
        //Moved the below method to Utility class.
        //public bool IsEmpty(string value)
        //{

        //    if (value.Length == 0)
        //    { return true; }
        //    return false;
        //}
        public void Insert()
        {
            if (CommonRoutines.IsEmpty(CustomerCode) && CommonRoutines.IsEmpty(CustomerName))
            { }
        }
    }
}
