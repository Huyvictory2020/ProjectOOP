using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Telephonist : Employee
    {
        protected double Allowance;
        public Telephonist() : base()
        {

        }
        public Telephonist(string name, string id, double birtyear, double numberofworkday, double basesalary, double salary, double allowance) : base( name,  id,  birtyear, numberofworkday,  basesalary,  salary)
        {
            this.Allowance = allowance;
        }
        public override void InputinformationofEmployee()
        {
            base.InputinformationofEmployee();
            Console.WriteLine("Type the Allowance:");
            this.Allowance = Convert.ToDouble(Console.ReadLine());
        }
        public override double FindSalary()
        {
            return base.FindSalary() + this.Allowance * 50;
        }
        public override void OutputinformationofEmployee()
        {
            base.OutputinformationofEmployee();
            Console.WriteLine("The Allowance:" + this.Allowance);
            this.Salary = FindSalary();
            Console.WriteLine("The salary of the Telephonist is:" + this.Salary);
        }
    }
}
