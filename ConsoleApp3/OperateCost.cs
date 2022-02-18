using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class OperateCost
    {
        public double salary;
        public double tax;

        public abstract void ApplyBonus(double bonus, double grade);
        public abstract void ApplyTax();
    }

    class Slave : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (10000 + 2 * bonus) * grade;
        }

        public override void ApplyTax()
        {
            tax = salary * 0.34;
        }
    }

    class Warden : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (100000 + 5 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.34;
        }
    }

    class Lord : OperateCost
    {
        public override void ApplyBonus(double bonus, double grade)
        {
            salary = (1000000 + 10 * bonus) * grade;
        }
        public override void ApplyTax()
        {
            tax = salary * 0.34;
        }
    }
}
