namespace Lesson1_SRP
{
    public interface IEmployee
    {
        int BaseRetirementSalary { get; set; }
        double MultiplicationDefault { get; set; }
    }

    class Employee : IEmployee
    {
        public int BaseRetirementSalary { get; set; } = 1000;
        public double MultiplicationDefault { get; set; } = 1;
    }

    class CEOEmployee : IEmployee
    {
        public int BaseRetirementSalary { get; set; } = 15000;
        public double MultiplicationDefault { get; set; } = 1.2;
    }
}