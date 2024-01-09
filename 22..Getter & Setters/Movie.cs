using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getter___Setters
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string title, string director, string rating)
        {
            this.title = title;
            this.director = director;
            this.Rating = rating;
        }

        public string Rating
        {
            get 
            {
                return this.rating;
            }
            set 
            {
                //G, PG, PG-13, NR
                if (value == "G" || value == "PG" || value=="PG-13" || value =="NR") 
                {
                this.rating = value;
                }
                else
                {
                    this.rating = "NR";
                }
            //4:04
            }
        }
    }
}
