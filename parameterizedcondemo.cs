using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoproject
{
    class parameterizedcondemo
    {
        int x;
        public parameterizedcondemo(int i)
        {
            x = i;
            Console.WriteLine("parameterized constructor is called:" + i);
        }
        public void desplay()
        {
            Console.WriteLine("value of x is:" + x);
        }
        static void Main()
        {
            parameterizedcondemo cd1 = new parameterizedcondemo(10);
            parameterizedcondemo cd2 = new parameterizedcondemo(20);

            cd1.desplay();
            cd2.desplay();
            Console.ReadLine();
        }
    }
}
