using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class NewStudent : Student
    {
        public void hasMoreDetails()
        {
            Console.WriteLine("New student has more details");
        }

        public override void hasBio()
        {
            Console.WriteLine("A student has no description");
        }
    }
}
