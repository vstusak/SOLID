using System;
using System.Collections.Generic;

namespace Lesson2_OCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var ocpApproaches = new OCPApproaches();

            ocpApproaches.ExtremelyConcrete();

            ocpApproaches.ParameterBased("Hello world! Parameter.");

            ocpApproaches.InheritanceBased();
            ocpApproaches = new OCPApproachesInherited();
            ocpApproaches.InheritanceBased();

            ocpApproaches = new OCPApproachesInjection(new HiGreetingsService());
            ((OCPApproachesInjection)ocpApproaches).InjectedBased();
        }
    }

    internal class GoodByeGreetingsService : IGreetingService
    {
        //public override string GetMessage()
        //{
        //    return base.GetMessage();
        //}

        public string GetMessage()
        {
            return "Good Bye!";
        }
    }

    class HiGreetingsService : IGreetingService
    {
        public string GetMessage()
        {
            List<string> list = new List<string>();

            return "Hi!";
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

        //public virtual void InjectedBased()
        //{
        //    throw new NotImplementedException();
        //}
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
        private readonly IGreetingService _greetingService;

        public OCPApproachesInjection(IGreetingService greetingService)
        {
            _greetingService = greetingService;
        }

        public void InjectedBased()
        {
            Console.WriteLine(_greetingService.GetMessage());
        }
    }

    public class GreetingsService : IGreetingService
    {
        public string GetMessage()
        {
            return "Hello World! Injected.";
        }
    }

    public interface IGreetingService
    {
        string GetMessage();
    }
}
