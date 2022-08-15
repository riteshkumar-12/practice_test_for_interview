using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
     abstract class AbstractMethod
    {
        private string data = string.Empty;
        public AbstractMethod(string name)
        {
            data = name;
            Console.WriteLine(data);
        }
    }
}
