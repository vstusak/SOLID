using System;
using System.Collections.Generic;

namespace Lesson4_ISP
{
    public class NotificationService : IEmailNotificationService, IPopupNotificationService
    {
        public void SendEmail(IEnumerable<string> addresses, string message)
        {
            throw new NotImplementedException();
        }

        public void ShowPopup(string clientUri, string message)
        {
            throw new NotImplementedException();
        }
    }
}
