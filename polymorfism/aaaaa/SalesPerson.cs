using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaa
{
    public class SalesPerson : Employee
    {
        public override double CalculateSalary()
        {
            return Salary + (Salary * 0.1);
        }
    }

}
