using System;
using System.Collections.Generic;

namespace Lesson4_ISP
{
    public class EmailNotificationService : IEmailNotificationService
    {
        public void SendEmail(IEnumerable<string> addresses, string message)
        {
            throw new NotImplementedException();
        }
    }
}
