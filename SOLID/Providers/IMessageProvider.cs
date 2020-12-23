using System;

namespace SOLID.Providers
{
    public interface IMessageProvider
    {
        void ShowMessageToUser(string message);
        ConsoleKeyInfo AskForKeyInputWithMessage(string message);
        string AskForInputWithMessage(string message);
    }
}