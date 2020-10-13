using System;
using System.Collections.Generic;

namespace Lesson4_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public interface INotificationService
    {
        void SendEmail(string address, string message);
        void SendEmail(IEnumerable<string> addresses, string message);
        void SendText(string phoneNumber, string message);
        void SendPostcard(string name, string street, string town, string message);
        void ShowPopup(string clientUri, string message);
    }
}
