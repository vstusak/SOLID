namespace Kindergarden.Contracts
{
    //TODO podivat se na dekompilovane rozdily mezi class a record / class a struct - DONE
    public class Person
    {
        public int PersonId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public PersonRoles Role { get; set; }
    }
}
