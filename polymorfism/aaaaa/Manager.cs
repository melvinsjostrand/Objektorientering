using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaaaa
{
    public class Manager : Employee
    {
        public override double CalculateSalary()
        {
            return Salary * 1.5;
        }
    }


}
