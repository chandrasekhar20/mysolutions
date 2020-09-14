using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadProject
{
    class Program
    {
        public void test()
        {
            Console.WriteLine("first method");
        }
        public void test(int i)
        {
            Console.WriteLine("second method");
        }
        public void test(string s)
        {
            Console.WriteLine("third method");
        }
        public void test(int i,string s)
        {
            Console.WriteLine("foruth method");
        }
        public void test(string s,int i)
        {
            Console.WriteLine("fifth method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.test();
            p.test(2);
            p.test("chandu");
            p.test(5,"chandu");
            p.test("chandu",5);
            Console.ReadLine();
        }
    }
}
