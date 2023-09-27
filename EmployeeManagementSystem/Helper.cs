using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    class Inputter
    {
        public static string TakeInput(string input) {
            Console.Write($"Enter {input} : ");
            return Console.ReadLine();
        }

    }
    class IDGenerator
    {
        public static int ID;
        static IDGenerator()
        {
            ID = 0;
        }
        public static int Generate()
        {
            return ID++;
        }
    }
}
