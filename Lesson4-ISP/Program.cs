using System;
using System.Collections.Generic;

namespace Lesson4_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmailNotificationService notificationService = new EmailAndPostcardNotificationService();
            notificationService.Send("Brno", "Ahoj!");
             
            ((IPostcardNotificationService)notificationService).Send("abc@rws.com", "Ahoj!");
        }
    }

    public class EmailAndPostcardNotificationService : IEmailNotificationService, IPostcardNotificationService
    {
        void IEmailNotificationService.Send(string address, string message)
        {
            Console.WriteLine("email");
        }

        void IPostcardNotificationService.Send(string address, string message)
        {
            Console.WriteLine("postcard");
        }

        public void Send(IEnumerable<string> addresses, string message)
        {
            throw new NotImplementedException();
        }

        public void Send(string name, string street, string town, string message)
        {
            throw new NotImplementedException();
        }
    }

    public interface IEmailNotificationService
    {
        void Send(string address, string message);
        void Send(IEnumerable<string> addresses, string message);
    }

    public interface ITextNotificationService
    {
        void Send(string phoneNumber, string message);
    }

    public interface IPostcardNotificationService
    {
        void Send(string name, string street, string town, string message);
        void Send(string address, string message);
    }

    public interface IPopupNotificationService
    {
        void Send(string clientUri, string message);
    }
}
