namespace EmployeeInheritance
{
    public class Employee
    {
        // pay calculation constatnts
        const decimal FULL_WEEK = 37.5m;
        const decimal OT_RATE = 1.5m;

        // private data
        private string name;
        private decimal hours;
        private decimal payRate;

        // Constructor with parameters
        public Employee(string name, decimal hours, decimal payRate)
        {
            this.name = name;
            this.hours = hours;
            this.payRate = payRate;
        }

        public virtual decimal CalculatePay()
        {
            if (hours <= FULL_WEEK) return hours * payRate;
            else return (FULL_WEEK * payRate) + ((hours - FULL_WEEK) * payRate);
        }

        public override string ToString()
        {
            return $"{name}: {hours}, {payRate:c}";
        }
    }
}