using System;
using System.Collections.Generic;

namespace Lesson3_LSP
{
    public static class LspExtensions
    {
        //public static string GetInfo(this Person person)
        //{
        //    return person switch
        //    {
        //        Male _ => "It's male",
        //        Female _ => "It's female",
        //        Children _ => "It's children",
        //        _ => "It's undefined"
        //    };
        //}
    }
    
    public class Violations
    {
        public void DoSomething()
        {
            var people = GeneratePeople();

            foreach (Person person in people)
            {
                Console.WriteLine(person.GetInfo()); 
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
        public virtual string GetInfo()
        {
            return "undefined";
        }
    }

    public class Male : Person
    {
        public override string GetInfo()
        {
            return "male";
        }
    }

    public class Female : Person
    {
        public override string GetInfo()
        {
            return "female";
        }
    }

    public class Children : Person
    {
        public override string GetInfo()
        {
            return "children";
        }
    }

    public class Turtle : Person
    {
        public override string GetInfo()
        {
            return "turtle";
        }
    }
}

