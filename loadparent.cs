using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overloadProject
{
    class loadparent
    {
        public void show()
        {
            Console.WriteLine("parents show method is called");
        }
        public virtual void test()
        {
            Console.WriteLine("parents test method is called");
        }
    }
    class loadchild : loadparent
    {
        public void show(int i)
        {
            Console.WriteLine("childs show method is called");
        }
        public override void test()
        {
            Console.WriteLine("childs test method is called");
        }
        static void Main()
        {
            loadchild c = new loadchild();
            c.show();
            c.test();
            c.show(10);
            Console.ReadLine();
        }
    }
}
