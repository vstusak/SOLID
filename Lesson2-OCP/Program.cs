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

            ocpApproaches = new OCPApproachesInjection(new GreetingsService());
            ((OCPApproachesInjection)ocpApproaches).InjectedBased();
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
        private readonly GreetingsService _greetingsService;

        public OCPApproachesInjection(GreetingsService greetingsService)
        {
            _greetingsService = greetingsService;
        }

        public void InjectedBased()
        {
            Console.WriteLine(_greetingsService.GetMessage());
        }
    }

    public class GreetingsService
    {
        public string GetMessage()
        {
            return "Hello World! Injected.";
        }
    }
}
