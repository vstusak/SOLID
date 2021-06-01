using System;
using System.Collections.Generic;

namespace Lesson4_ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPostcardNotificationService service = new CzechPostCardService();
            //service.SendEmail(string.Empty,string.Empty);
            service.SendPostcard("Me", "Home", "Hometown", "Hey");

            //CzechPost already implements IText.. Casting is okay as is
            ((ITextNotificationService)service).SendText("1", "message");

            ITextNotificationService test = service as ITextNotificationService;
            ITextNotificationService test2 = (ITextNotificationService)service;


            ITextNotificationService messageService = new CzechPostCardService();

            messageService.SendText("1", "message");
        }
    }

    //public interface INotificationService
    //{
    //    void SendEmail(string address, string message);
    //    void SendEmail(IEnumerable<string> addresses, string message);
    //    void SendText(string phoneNumber, string message);
    //    void SendPostcard(string name, string street, string town, string message);
    //    void ShowPopup(string clientUri, string message);

    //}

    interface IEmailNotificationService
    {
        void SendEmail(string address, string message);
        void SendEmail(IEnumerable<string> addresses, string message);
    }

    interface ITextNotificationService
    {
        void SendText(string phoneNumber, string message);
    }

    interface IPostcardNotificationService
    {
        void SendPostcard(string name, string street, string town, string message);
    }

    interface IPopupNotificationService
    {
        void ShowPopup(string clientUri, string message);
    }

    public class CzechPostCardService : IPostcardNotificationService, ITextNotificationService
    {
        public void SendPostcard(string name, string street, string town, string message)
        {
            Console.WriteLine($"Postcard sent to {name}");
        }

        public void SendText(string phoneNumber, string message)
        {
            Console.WriteLine($"SMS sent to {phoneNumber}");
        }

        //public void SendText(string phoneNumber, string message)
        //{
        //    throw new NotImplementedException();
        //}
    }

    //TODO: Create object with multiple interfaces
}
