using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace variablestypes
{
    class Program
    {
        int x;
        const float pi = 3.14f;
        readonly bool flag;
        public Program(int x,bool flag)
        {
            this.x = x;
            this.flag = flag;
        }
        static void Main(string[] args)
        {
            int y = 200;
            Program p1 = new Program(10,true);
            Program p2 = new Program(20,false);
            Console.WriteLine(p1.x+"  "+p2.x);
            Console.WriteLine(p1.flag + "   " + p2.flag);
            p1.x = 200;
            Console.WriteLine(y);
            Console.WriteLine(pi);
            Console.ReadLine();
        }
    }
}
