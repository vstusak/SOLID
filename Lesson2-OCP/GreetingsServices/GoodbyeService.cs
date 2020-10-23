namespace Lesson2_OCP.GreetingsServices
{
    internal class GoodbyeService : IGreetingsService
    {
        public string GetMessage()
        {
            return "Goodbye";
        }
    }
}