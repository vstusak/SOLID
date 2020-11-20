using System;

namespace Lesson4_ISP
{
    public class Email
    {
        public string Address { get; }

        public string Message { get; }

        public Email(string address, string message)
        {
            Address = address ?? throw new ArgumentNullException(nameof(address));
            Message = message ?? throw new ArgumentNullException(nameof(message));
        }
    }
}
