using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Student
    {
     
        public void hasID()
        {
            Console.WriteLine("A student has an ID number");
        }

        public void hasName()
        {
            Console.WriteLine("A student has a name");
        }

        public virtual void hasBio()
        {
            Console.WriteLine("A student has a description");
        }

    }
}
