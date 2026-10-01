using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
    public class Movie
    {
        public string Title { get; set; }
        public int Timetitle { get; set; }
        public Movie(string title = "", int timetitle = 0)
        {
            Title = title;
            Timetitle = timetitle;
        }
    }
}
