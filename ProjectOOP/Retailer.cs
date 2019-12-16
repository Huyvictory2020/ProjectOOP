using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Retailer : Employee
    {
        protected double Commission;
        public Retailer() : base()
        {

        }
        public Retailer(string name, string id, double birtyear, double numberofworkday, double basesalary, double salary, double commission) :base(name,  id,  birtyear, numberofworkday,  basesalary,  salary)
        {
            this.Commission = commission;
        }
        public override void InputinformationofEmployee()
        {
            base.InputinformationofEmployee();
            Console.WriteLine("Type the Commission:");
            this.Commission = Convert.ToDouble(Console.ReadLine());
        }
        public override double FindSalary()
        {
            return base.FindSalary() + this.Commission * 100;
        }
        public override void OutputinformationofEmployee()
        {
            base.OutputinformationofEmployee();
            Console.WriteLine("The Commission:" + this.Commission);
            this.Salary = FindSalary();
            Console.WriteLine("Salary of Retailer is:" +this.Salary);
        }
    }
}
