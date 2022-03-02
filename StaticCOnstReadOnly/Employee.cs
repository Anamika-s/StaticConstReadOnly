using System;
using System.Collections.Generic;
using System.Text;

namespace StaticCOnstReadOnly
{
    class Employee
    {
        readonly int id;
        string name;
        static string manager;
        public const string company="Dr.Lal Path Lab";
        decimal salary;
        static Employee()
        {
            manager = "Ajay";
        }
        public Employee()
        {

        }
        public Employee(int id, string name, string manager,
            string company, decimal salary)
        {
            this.id = id;
            this.name = name;
            manager = manager;
            this.salary = salary;
            company = company;

        }
        public void GetDetails()
        {
            //Console.WriteLine("Enter ID");
            //    id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
                name = Console.ReadLine();
            //Console.WriteLine("Enter Company Name");
            
            //company =  Console.ReadLine();
            Console.WriteLine("Enter salary");
            salary = Decimal.Parse(Console.ReadLine());
           

        }
        public static void GetManager()
        {
            Console.WriteLine("Enter manager");
            manager = Console.ReadLine();
            Console.WriteLine("Manager is " + manager);
        }
    }
}
