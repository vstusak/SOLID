namespace Lesson4_ISP
{
    public interface IPostcardNotificationService
    {
        void SendPostcard(string name, string street, string town, string message);
    }
}
