using System;
using SOLID.Models;
using SOLID.Providers;

namespace SOLID.Communication
{
    public class ConsoleCommunication : ICommunication
    {
        private const string DefaultMessageForInput = "\nInput a value for \"{0}\"";

        private readonly IMessageProvider _messageProvider;

        public ConsoleCommunication(IMessageProvider messageProvider)
        {
            _messageProvider = messageProvider;
        }

        public Input CollectUsersInputValues()
        {
            var input1 = _messageProvider.AskForInputWithMessage(
                string.Format(DefaultMessageForInput, nameof(Input.FirstNumber)));

            if (!int.TryParse(input1, out int value1))
            {
                throw new ArgumentException(nameof(Input.FirstNumber));
            }

            var input2 = _messageProvider.AskForInputWithMessage(
                string.Format(DefaultMessageForInput, nameof(Input.SecondNumber)));

            if (!int.TryParse(input2, out int value2))
            {
                throw new ArgumentException(nameof(Input.SecondNumber));
            }

            return new Input
            {
                FirstNumber = value1,
                SecondNumber = value2
            };
        }

        public Operand CollectUsersOperand()
        {
            var operand = _messageProvider.AskForKeyInputWithMessage(
                string.Format(DefaultMessageForInput, nameof(Operand)));

            if (!Enum.TryParse(typeof(Operand), operand.Key.ToString(), out var output))
            {
                throw new ArgumentException(nameof(Operand));
            }

            return (Operand)output;
        }
    }
}
