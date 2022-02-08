using System;
using Lesson2_OCP.GreetingsServices;

namespace Lesson2_OCP
{
    public class Program
    {
        //comment line/block/selected rows -> CTRL + K, C
        //uncomment - || - -> CTRL + K, U
        //complexita kodu -> Code Metrices

        static void Main(string[] args)
        {
            OCPApproaches ocpApproaches = new OCPApproaches();
            ocpApproaches.ExtremelyConcrete();

            ocpApproaches.ParameterBased("Hello world! Parameter.");

            //Log(ocpApproaches);
            ocpApproaches.InheritanceBased();
            ocpApproaches = new OCPApproachesInherited();
            ocpApproaches.InheritanceBased();
            //Log(new OCPApproachesInherited());

            ocpApproaches = new OCPApproachesInjection(new GoodbyeService());
            ((OCPApproachesInjection)ocpApproaches).InjectedBased();
        }

        //public static void Log(OCPApproaches messageWriter)
        //{
        //    messageWriter.InheritanceBased();
        //}
    }

    //internal class GoodbyeService : GreetingsService
    //{
    //    public override string GetMessage()
    //    {
    //        return "Good bye!";
    //    }
    //}

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
        private readonly IGreetingsService _greetingsService;

        public OCPApproachesInjection(IGreetingsService greetingsService)
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
        public virtual string GetMessage()
        {
            return "Hello World! Injected.";
        }
    }
}
