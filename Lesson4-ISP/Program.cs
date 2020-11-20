namespace Lesson4_ISP
{
    static class Program
    {
        static void Main(string[] args)
        {
            var emailNotificationService = new EmailNotificationService();
            var notificationServiceAdapter = new EmailNotificationServiceAdapter(emailNotificationService);

            Email email = new("example@mail.com", "Hello!");
            notificationServiceAdapter.SendEmail(email);
        }
    }
}
