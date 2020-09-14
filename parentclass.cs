using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace demo
{
    class parentclass
    {
        public virtual void test1()
        {
            Console.WriteLine("method test1 from parent class");
        }
        public void test2()
        {
            Console.WriteLine("method test2 from parent class");
        }
    }
    class childclass : parentclass
    {
        public override void test1()         //method overriding.
        {
            Console.WriteLine("method test1 from child class");
        }
        public new void test2()              //method hiding (or) shadowing.
        {
            Console.WriteLine("method test2 from child class");
        }
        static void Main()
        {
            childclass c = new childclass();     //instance of a child class.
            parentclass p = c;                  //p is a references of a parent class created by using child class.
            p.test1();                         //invokes child classes method when it's under overriden.
            p.test2();                        //invokes parent classes method.
            Console.ReadLine();
        }


    }
}
