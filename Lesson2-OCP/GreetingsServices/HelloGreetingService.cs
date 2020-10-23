namespace Lesson2_OCP.GreetingsServices
{
    public class HelloGreetingService : IGreetingsService
    {
        public string GetMessage()
        {
            return "Hello";
        }
    }
}