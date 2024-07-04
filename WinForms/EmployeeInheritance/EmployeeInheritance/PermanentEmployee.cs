using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeInheritance
{
    public class PermanentEmployee : Employee // inherits from employee
    {

        private decimal rrspPercent;

        public PermanentEmployee(string name, decimal hours, decimal payRate, decimal rrspPercent) : base(name, hours, payRate)
        {
            // only initialize specific data
            this.rrspPercent = rrspPercent;
        }

        // public methods
        public override string ToString()
        {
            return $"{base.ToString()}, {rrspPercent:p}";  
        }

        public decimal CalculateRrsp()
        {
            decimal basePay = base.CalculatePay(); // call method from base class
            return basePay * rrspPercent;
        }

        public override decimal CalculatePay()
        {
            decimal deduction = CalculateRrsp();
            return base.CalculatePay() - deduction; // call method from base class
        }
    }
}
