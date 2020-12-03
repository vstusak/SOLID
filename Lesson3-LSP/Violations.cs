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
            //if (person is Male) - equivalent to 
            if (person.GetType() == typeof(Male) && person != null)
            {
                Console.WriteLine("It's male");
            }
            else if (person is Female)
            {
                Console.WriteLine("It's female");
            }
            else
            {
                Console.WriteLine("It's undefined");
            }
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

    }

    public class Male : Person
    {

    }

    public class Female : Person
    {

    }

    public class Child: Person
    {

    }
}

