using System.Collections.Generic;

namespace Lesson4_ISP
{
    public class EmailNotificationServiceAdapter : IEmailNotificationServiceAdapter
    {
        private readonly IEmailNotificationService _emailNotificationService;

        public EmailNotificationServiceAdapter(IEmailNotificationService emailNotificationService)
        {
            _emailNotificationService = emailNotificationService;
        }

        public void SendEmail(Email email)
        {
            _emailNotificationService.SendEmail(new List<string> { email.Address }, email.Message);
        }
    }
}
