using System;

namespace Lesson2_OCP
{
    public class Program
    {
        private static void Main(string[] args)
        {
            OCPApproaches ocpApproaches = new OCPApproaches();

            //ocpApproaches.ExtremelyConcrete();

            //ocpApproaches.ParameterBased("Hello world! Parameter.");

            //ocpApproaches.InheritanceBased();
            //ocpApproaches = new OCPApproachesInherited();
            //ocpApproaches.InheritanceBased();

            ocpApproaches = new OCPApproachesInjection(new GoodByeService());
            ((OCPApproachesInjection)ocpApproaches).InjectedBased();
            Console.ReadLine();
        }
    }

    public class OCPApproaches
    {
        public void ExtremelyConcrete()
        {
            Console.WriteLine("Hello World! Concrete.");
        }

        public void ParameterBased(string message)
        {
            Console.WriteLine(message);
        }

        public virtual void InheritanceBased()
        {
            Console.WriteLine("Hello World! Inherited parent.");
        }
    }

    public class OCPApproachesInherited : OCPApproaches
    {
        public override void InheritanceBased()
        {
            Console.WriteLine("Hello World! Inherited child.");
        }
    }

    public class OCPApproachesInjection : OCPApproaches
    {
        private readonly IGreetings _greetingsService;

        public OCPApproachesInjection(IGreetings greetings)
        {
            _greetingsService = greetings;
        }

        public void InjectedBased()
        {
            Console.WriteLine(_greetingsService.GetMessage());
        }
    }

    public class GreetingsService : IGreetings
    {
        public string GetMessage()
        {
            return "Hello World! Injected.";
        }
    }

    public interface IGreetings
    {
        string GetMessage();
    }

    public class GoodByeService : IGreetings
    {
        public string GetMessage()
        {
            return "Goodbye";
        }
    }
}