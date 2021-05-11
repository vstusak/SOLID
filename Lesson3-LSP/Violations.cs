using System;
using System.Collections.Generic;

namespace Lesson3_LSP
{
    public static class Extensions
    {
        public static string GetDescription(this Person person, int count)
        {
            return person switch
            {
                Male _ => "It's male",
                Female _ => "It's female",
                Child _ => "It's child",
                Turtle _ => "It's turtle",
                _ => "It's undefined"
            };
        }
    }
    public class Violations
    {
        public void DoSomething()
        {
            var people = GeneratePeople();

            foreach (Person person in people)
            {
                //Console.WriteLine(person.GetDescription(5));
                Console.WriteLine(person.GetText());
            }
        }

        private IEnumerable<Person> GeneratePeople()
        {
            return new List<Person>
            {
                new Person(), new Female(), new Male(), new Person(), new Female(), new Male(), new Child(), new Turtle()
            };
        }
    }

    public class Person
    {
        public virtual string GetText()
        {
            return "It's undefined";
        }
    }

    public class Male : Person
    {
        public override string GetText()
        {
            return "It's male";
        }
    }

    public class Female : Person
    {
        public override string GetText()
        {
            return "It's female";
        }
    }

    public class Child : Person
    {
        public override string GetText()
        {
            return "It's child";
        }
    }

    public class Turtle : Person
    {
        public override string GetText()
        {
            return "It's turtle";
        }
    }
}