namespace Lesson1_SRP.Entities
{
    public class CEO : Person, IPerson
    {
        public override int BaseSalary => 40000;
    }
}