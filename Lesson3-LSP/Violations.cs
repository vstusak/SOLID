using System;
using System.Collections.Generic;

namespace Lesson3_LSP
{
    public class Violations
    {
        public void DoSomething()
        {
            var people = GeneratePeople();

            foreach (Person person in people)
            {
                if (person is Male)
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

        }

        private IEnumerable<Person> GeneratePeople()
        {
            return new List<Person>
            {
                new Person(), new Female(), new Male(), new Person(), new Female(), new Male()
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
}

