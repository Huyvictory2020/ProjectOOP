using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    interface Input
    {
        void InputinformationofEmployee();
    }
    interface Output
    {
        void OutputinformationofEmployee();
    }
    interface findsalary
    {
         double FindSalary();
    }
    class Employee : Input, Output, findsalary
    {
        protected string Name;
        protected string Id;
        protected double Birthyear;
        protected double Numberofworkday;
        protected double BaseSalary;
        protected double Salary;
        protected string Rank;
        public double salary
        {
            get { return this.Salary; }
            set { this.Salary = value; }
        }
        public string ID
        {
            get { return this.Id; }
            set { this.Id = value; }
        }
        public string NAME
        {
            get { return this.Name; }
            set { this.Name = value; }
        }
        public double numberofworkday
        {
            get { return this.Numberofworkday; }
            set { this.Numberofworkday = value; }
        }
        public string rank
        {
            get { return this.Rank; }
            set { this.Rank = value; }
        }
        public Employee()
        {

        }
        public Employee(string name, string id, double birtyear, double numberofworkday, double basesalary, double salary)
        {
            this.Name = name;
            this.Id = id;
            this.Birthyear = birtyear;
            this.Numberofworkday = numberofworkday;
            this.BaseSalary = basesalary;
            this.Salary = salary;
        }
        public virtual void InputinformationofEmployee()
        {
            Console.WriteLine("Type the name of the employee");
            this.Name = Console.ReadLine();
            Console.WriteLine("Type the ID");
            this.Id = Console.ReadLine();
            Console.WriteLine("Type numberofworkday:");
            this.Numberofworkday = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the BirthYear");
            this.Birthyear = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Type the BaseSalary");
            this.BaseSalary = Convert.ToDouble(Console.ReadLine());
        }
        public virtual double FindSalary()
        {
            return this.BaseSalary;
        }
        public virtual void OutputinformationofEmployee()
        {
            Console.WriteLine("Name of employee:" + this.Name);
            Console.WriteLine("ID:" + this.Id);
            Console.WriteLine("Numberofworkday:" + this.Numberofworkday);
            Console.WriteLine("Birth Year:" + this.Birthyear);
            Console.WriteLine("BaseSalary:" + this.BaseSalary);
        }
    }
}
