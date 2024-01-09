using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Object_Methods
{
    internal class Student
    {
        public string name;
        public double gpa;
        public string major;
        
        public Student(string name, double gpa, string major)
        {
            this.name = name;
            this.gpa = gpa;
            this.major = major;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.4)
            {
                return true;
            }
            return false;
        }
    }
}
