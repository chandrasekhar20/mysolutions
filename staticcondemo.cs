using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class staticcondemo
    {
        static staticcondemo()
        {
            Console.WriteLine("static constructor is executed");    
        }
        static void Main()
        {
            Console.WriteLine("main method is executed");
        }
    }
}
