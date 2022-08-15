using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice.StaticClasses
{
    public static class CommonRoutines
    {
        public static bool IsEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            { return true; }
            return false;
        }
        public static string ComputerName() { return System.Environment.MachineName; }
    }


    //Notes :- 

    // 1. public class MyTEST : CommonRoutines
    //{ 
    //cannot inherit form static class;
    //}

    // 2.  public interface ITest { does not work on CommonRoutine class. }

    // 3.  ALso abstract keyword does not work on CommonRoutines class

}
