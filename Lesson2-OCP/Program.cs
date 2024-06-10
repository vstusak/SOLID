using System;

namespace Lesson2_OCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            OCPApproaches ocpApproaches = new OCPApproaches();

            ocpApproaches.ExtremelyConcrete();

            ocpApproaches.ParameterBased("Hello world! Parameter.");

            ocpApproaches.InheritanceBased();
            ocpApproaches = new OCPApproachesInherited();
            ocpApproaches.InheritanceBased();

            var ocpApproachesInjected = new OCPApproachesInjection(new GoodbyeService());
            ocpApproachesInjected.InjectedBased();
        }
    }

    public class OCPApproachesInjection 
    {
        private readonly IGetMessage _greetingsService;

        public OCPApproachesInjection(IGetMessage greetingsService)
        {
            _greetingsService = greetingsService;
        }

        public void InjectedBased()
        {
            Console.WriteLine(_greetingsService.GetMessage());
        }
    }

    public class GreetingsService : IGetMessage
    {
        public string GetMessage()
        {
            return "Hello World! Injected.";
        }
    }

    public class GoodbyeService : IGetMessage
    {
        public string GetMessage()
        {
            return "Bye - bye.";
        }
    }

    public interface IGetMessage 
    {
        string GetMessage();
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
}
