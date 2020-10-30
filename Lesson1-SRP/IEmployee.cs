namespace Lesson1_SRP
{
    public interface IEmployee
    {
        int BaseRetirementSalary { get; set; }
    }

    class Employee : IEmployee
    {
        public int BaseRetirementSalary { get; set; } = 1000;

    }

    class CEOEmployee : IEmployee
    {
        public int BaseRetirementSalary { get; set; } = 15000;
    }
}