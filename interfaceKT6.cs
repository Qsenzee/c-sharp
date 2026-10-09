using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaceKT6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<INotifier> notifiers = new List<INotifier>
            {
                new EmailNotifier(),
                new SmsNotifier(),
                new TelegramNotifier()
            };

            foreach (var notifier in notifiers)
            {
                notifier.Send("Интерфейсы — это круто!");
            }
        }
    }
    public interface INotifier
    {
        void Send(string message);
    }
    public class EmailNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email: {message}");
        }
    }
    public class SmsNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }
    public class TelegramNotifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine($"Telegram: {message}");
        }
    }
}
