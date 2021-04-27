namespace Lesson1_SRP.Entities
{
    public class Worker : Person, IPerson
    {
        public override int BaseSalary => 20000;
    }
}