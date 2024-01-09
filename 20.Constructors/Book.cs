using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_and_Objects
{
    internal class Book
    {

        public string author;
        public string name;
        public int pages;

        public Book(string name, string author, int pages )
        {
           this.name = name;
            this.author = author;
            this.pages = pages;
        }
    }
}
