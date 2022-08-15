using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StringAndStringBuilder : Testing
    {
        Employee4 empData = new Employee4();
        Testing tests = new Testing();
    }



    public class Testing
    {
        public string name, Address;
        public string test()
        {
            return "Ritesh";
        }
    }

    public class Employee4
    {
        public string id;
        public string name;

        public Employee4()
        {
        }

        public Employee4(string name, string id)
        {
            this.name = name;
            this.id = id;
        }

        public string Testing()
        {
            return "ritesh";
        }

        public static int employeeCounter;

        public static int AddEmployee()
        {
            return ++employeeCounter;
        }
    }
}
