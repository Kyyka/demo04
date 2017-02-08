using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teht03
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Tipi Taapertaja", "Töymiäss", 1800);
            Console.WriteLine("Employee:\n- " + employee.ToString());

            Boss boss = new Boss("Taneli Betoni", "Johtaja", 5000, "Lamborghini", 15000);
            Console.WriteLine("Boss:\n- " + boss.ToString());

            employee.Salary = 2700;
            Console.WriteLine("Employee:\n- " + employee.ToString());
        }
    }
}
