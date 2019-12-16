using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Guard : Employee
    {
        protected double Bonus;
        public Guard() :base()
            {

            }
        public Guard(string name, string id, double birtyear, double numberofworkday, double basesalary, double salary, double bonus) : base(name, id, birtyear, numberofworkday, basesalary, salary)
        {
            this.Bonus = bonus;
        }
        public override void InputinformationofEmployee()
        {
            base.InputinformationofEmployee();
            Console.WriteLine("Type the Bonus:");
            this.Bonus = Convert.ToDouble(Console.ReadLine());
        }
        public override double FindSalary()
        {
            return base.FindSalary() + this.Bonus *200;
        }
        public override void OutputinformationofEmployee()
        {
            base.OutputinformationofEmployee();
            Console.WriteLine("Bonus: " + this.Bonus);
            this.Salary = FindSalary();
            Console.WriteLine("The salary of the Guard is:" + this.Salary);
        }
    }
}
