using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var movies = new List<Movie>
        {
               new Movie("Побег из Шоушенка", 142),
               new Movie("Крёстный отец", 175),
               new Movie("Форрест Гамп", 142)
        };
            var hall = new CinemaHall(10);
            var service = new BookingService(movies, hall);

            Console.Write("Ваше имя: ");
            var customer = new Customer(Console.ReadLine());

            for (int i = 0; i < movies.Count; i++)
                Console.WriteLine($"{i + 1}. {movies[i].Title} ({movies[i].Minutes} мин)");

            Console.Write("Выберите фильм: ");
            service.SelectMovie(int.Parse(Console.ReadLine()));

            hall.Show();
            Console.Write("Выберите место (1-10): ");
            service.SelectSeat(int.Parse(Console.ReadLine()));

            try
            {
                service.Book(customer);
                Console.WriteLine("Забронировано!");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            Console.WriteLine("Схема зала:");
            hall.Show();

            Console.Write("Отменить бронь? (y/n): ");
            if (Console.ReadLine() == "y")
            {
                service.Cancel(customer);
                hall.Show();
            }
            for (int i = 0; i < movies.Count; i++)
                Console.WriteLine($"{i + 1}. {movies[i].Title} ({movies[i].Minutes} мин)");
        }
    }

    class Movie
    {
        public string Title;
        public int Minutes;
        public Movie(string title, int minutes) { Title = title; Minutes = minutes; }
    }

    class Seat
    {
        public int Number;
        public bool IsTaken;
        public Seat(int number) { Number = number; }

        public void Reserve()
        {
            if (IsTaken) throw new Exception("Место уже занято!");
            IsTaken = true;
        }
    }

    class CinemaHall
    {
        public List<Seat> Seats = new List<Seat>();

        public CinemaHall(int count)
        {
            for (int i = 1; i <= count; i++) Seats.Add(new Seat(i));
        }

        public void Show()
        {
            foreach (var s in Seats)
                Console.Write(s.IsTaken ? "[X] " : $"[{s.Number}] ");
            Console.WriteLine();
        }
    }
    class Customer
    {
        public string Name;
        public List<string> Bookings = new List<string>();
        public Customer(string name) { Name = name; }
    }
    class BookingService
    {
        public List<Movie> Movies;
        public CinemaHall Hall;
        public Movie SelectedMovie;
        public Seat SelectedSeat;

        public BookingService(List<Movie> movies, CinemaHall hall)
        {
            Movies = movies;
            Hall = hall;
        }

        public void SelectMovie(int n) { SelectedMovie = Movies[n - 1]; }
        public void SelectSeat(int n) { SelectedSeat = Hall.Seats[n - 1]; }

        public void Book(Customer c)
        {
            SelectedSeat.Reserve();
            c.Bookings.Add(SelectedMovie.Title + ", место " + SelectedSeat.Number);
        }

        public void Cancel(Customer c)
        {
            SelectedSeat.IsTaken = false;
            c.Bookings.Clear();
        }
    }
}