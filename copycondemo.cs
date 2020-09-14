using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class copycondemo
    {
        int x;
        public copycondemo(int i)
        {
            x = i;
        }
        public copycondemo(copycondemo obj)
        {
            x = obj.x;
        }
        public void display()
        {
            Console.WriteLine("the value of x is:" + x);

        }
        static void Main()
        {
            copycondemo cd1 = new copycondemo(10);

            cd1.display();
            copycondemo cd2 = new copycondemo(cd1);
            cd2.display();
            Console.ReadLine();
        }
    }
}
