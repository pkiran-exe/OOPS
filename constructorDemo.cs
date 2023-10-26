using OOPS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class constructorDemo
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();//0&null
            Employee emp1 = new Employee(12, "Gauri", "Bangalore");
            Employee emp2 = new Employee(13, "Rajashri");
            Employee emp3 = new Employee(empid: 78, loc: "TamilNadu", name: "Harish");
            Console.WriteLine(emp1.Employeeid);
            Console.WriteLine(emp1.EmpName);
            Console.WriteLine(emp1.Location);
            Console.WriteLine("---------------");
            Console.WriteLine(emp3.Details);
            Console.ReadLine();

        }
    }
}