using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class explicitcondemo
    {
        public explicitcondemo()
        {
            Console.WriteLine("Constructor is called.");
        }
        static void Main()
        {
            explicitcondemo obj = new explicitcondemo();
            Console.ReadLine();
        }
    }
}
