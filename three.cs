using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace accessdemo1
{  //case 3: consuming members of a class from non-child class of same project.
    class three
    {
        static void Main()
        {
            Program p = new Program();
            p.Test2();
            p.Test4();
            p.Test5();
            Console.ReadLine();
        }
    }
}
