namespace Kindergarden.Contracts
{
    //TODO podivat se na dekompilovane rozdily mezi class a record / class a struct - https://learn.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-9#records
    public class Person
    {
        public DateTime DateOfBirth { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }

        public PersonRoles Role { get; set; }
    }
}
