using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSalesT
{
    internal class Movie
    {
        //create auto properties for Movie class
        public string MovieTitle { get; set; }
        public double MoviePrice { get; set; }
        public string MovieGenre { get; set; }

        public Movie() 
        {
            MovieTitle = "";
            MoviePrice = 0.0;
            MovieGenre = "";    
        }
        
        public Movie(string Title, double Price , string Genre)
        {
            MoviePrice = Price;
            MovieTitle = Title;
            MovieGenre = Genre;
        }

        public override string ToString()
        { 
            return "The Movie Title is: " + MovieTitle + ". The Movie Price is: " + MoviePrice.ToString("n2") + ". The Movie Genre is: " + MovieGenre;
        }
    }
}
