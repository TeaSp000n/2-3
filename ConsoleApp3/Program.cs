using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            OperateCost oc = new Warden();
            Employee emp = new Employee("Petya", "Ivanov", "15.03.2002", oc);
            double grade = Employee.DiscoverGrade("15.03.2002");
            Console.WriteLine("Name: {0}, Surname: {1}, Date of Hire: {2}, Positoin: {3}", emp.name, emp.surname, Employee.dateOfHire, emp.operationCost);
            oc.ApplyBonus(25000, grade);
            oc.ApplyTax();
            Console.WriteLine("Salary: {0}, Tax: {1}", emp.operationCost.salary, emp.operationCost.tax);
            Console.ReadKey();
        }
    }
}
