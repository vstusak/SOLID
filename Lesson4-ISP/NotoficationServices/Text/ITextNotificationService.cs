namespace Lesson4_ISP
{
    public interface ITextNotificationService
    {
        void SendText(string phoneNumber, string message);
    }
}
