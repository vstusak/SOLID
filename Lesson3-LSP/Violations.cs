using System;
using System.Collections.Generic;

namespace Lesson3_LSP
{
    public static class Extensions
    {
        /// <summary>
        /// Write information about person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="text"></param>
        public static void WriteInfo(this Person person, string text)
        {
            switch (person) // Must be extended when something is changed in code - added child turtle etc.
            {
                case Male male:
                    Console.WriteLine("It's male");
                    break;
                case Female _:
                    Console.WriteLine("It's female");
                    break;
                default:
                    Console.WriteLine("It's undefined");
                    break;
            }
            //if (person is Male) - equivalent to 
            //if (person.GetType() == typeof(Male) && person != null)
            //{
            //    Console.WriteLine("It's male");
            //}
            //else if (person is Female)
            //{
            //    Console.WriteLine("It's female");
            //}
            //else
            //{
            //    Console.WriteLine("It's undefined");
            //}
        }

        public static void NotNullOrArgumentNullException(this string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException();
            }
        }
    }

    public class Violations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="inputParameter"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public void DoSomething(string inputParameter)
        {
            inputParameter.NotNullOrArgumentNullException();

            var people = GeneratePeople();

            //Female karla = null;
            //karla.GetType(); -> typeof(Female)

            foreach (Person person in people)
            {
                //TODO show the quick help - CTRL+SHIFT+F1 alternative
                person.WriteInfo(inputParameter);
                person.ShowDescription(inputParameter);
            }
        }

        private IEnumerable<Person> GeneratePeople()
        {
            return new List<Person>
            {
                new Person(), new Female(), new Male(), new Person(), new Female(), new Male(), new Child()
            };
        }
    }

    public class Person
    {
        public virtual void ShowDescription(string infoText)
        {
            Console.WriteLine("It's undefined");
        }
    }

    public class Male : Person
    {
        public override void ShowDescription(string infoText)
        {
            Console.WriteLine("It's male");
        }
    }

    public class Female : Person
    {
        public override void ShowDescription(string infoText)
        {
            Console.WriteLine("It's female");
        }
    }

    public class Child : Person
    {
        public override void ShowDescription(string infoText)
        {
            Console.WriteLine("It's child");
        }
    }

    public class Turtle: Person
    {
        public override void ShowDescription(string infoText)
        {
            Console.WriteLine("It's turtle");
        }
    }
}

