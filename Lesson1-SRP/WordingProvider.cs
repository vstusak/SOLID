namespace Lesson1_SRP
{
    public class WordingProvider
    {
        private const string HappyRetirementMsg = "Congratulations and have a nice retirement.";
        private const string YourRetirementWillSuckMsg = "You will need additional work now or in retirement, sorry.";
        private const int LimitValue = 20000;
        
        public string GetOutputMessageForRetirementSalaryCalculation(int retirementSalary)
        {
            if (retirementSalary > LimitValue)
            {
                // standardized output should be in separate constants outside code
                // at least a const within the class such as above
                return HappyRetirementMsg; 
            }
            else
            {
                return YourRetirementWillSuckMsg;
            }
        }
    }
}