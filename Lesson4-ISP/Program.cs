namespace Lesson4_ISP
{
    static class Program
    {
        static void Main(string[] args)
        {
            var emailNotificationService = new EmailNotificationService();
            var notificationServiceAdapter = new EmailNotificationServiceAdapter(emailNotificationService);

            var email = new Email("example@mail.com", "Hello!");
            notificationServiceAdapter.SendEmail(email);
        }
    }
}
