using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animals cat = new Animals();
            cat.Type = "Cat";
            cat.Age = 67;
            cat.Name = "Лэ Дауньон";
            cat.Sound = "Meow";
            Console.WriteLine(cat.getInfo());
            Console.WriteLine(cat.sayHello());
            cat.getInfo();
            cat.sayHello();

            Animals Boozer = new Animals();
            Boozer.Type = "Алкаш";
            Boozer.Age = 17;
            Boozer.Name = "Я";
            Boozer.Sound = "Meow";
            Console.WriteLine(Boozer.getInfo());
            Console.WriteLine(Boozer.sayHello());
            Boozer.getInfo();
            Boozer.sayHello();
        }
    }
    public class Animals
    {
        public string Type;
        public int Age;
        public string Name;
        public string Sound;

        public Animals(string type, int age, string name, string sound)
        {
            Type = type;
            Age = age;
            Name = name;
            Sound = sound;
        }

        public string type
        {
            get { return Type; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter a type");
                }
                else Type = value;
            }
        }

        public int age
        {
            get { return Age; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine();
                }
                else Age = value;
            }
        }

        public string name
        {
            get { return name; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("Enter your name");
                }
                else name = value;
            }
        }
        public string sound
        {
            get { return sound; }
            set
            {
                if (value == null || value == "")
                {
                    Console.WriteLine("You have to enter an sound");
                }
                else sound = value;
            }
        }    

        public string getInfo()
        {
            return $"Вид: {Type}\n Возраст: {Age}\n Кличка: {Name}";
        }
        public string sayHello()
        {
            return "Sound";
        }
    }
}
