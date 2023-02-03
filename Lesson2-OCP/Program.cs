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
            ((OCPApproaches)ocpApproaches).InheritanceBased();
            var obj = new OCPApproachesInjection();
            obj.InjectedBased();
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

    public class OCPApproachesInjection
    {
        //private readonly IService _greetingsService;

        //public OCPApproachesInjection(IService greetingsService)
        //{
        //    _greetingsService = greetingsService;
        //}

        public void InjectedBased()
        {
            var _greetingsService = new TServisa();
            Console.WriteLine(_greetingsService.GetMessage());
        }
    }

    public class GreetingsService : IService
    {
        public string GetMessage()
        {
            return "Hello World! Injected.";
        }
    }

    public interface IService
    {
        string GetMessage();

    }

    public class TServisa : IService
    {
        public string GetMessage()
        {
            return "Hello it's Friday";
        }
    }
}
