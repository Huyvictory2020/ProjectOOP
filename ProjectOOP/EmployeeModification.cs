using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{

    interface Ifindgreatestsalary
    {
        void Employeewithgreatestsalary();
    }
    interface Ifindtotalsalary
    {
        void Findtotalsalary();
    }
    interface Iremove
    {
        void Remove();
    }
    interface Isort
    {
        void Sortdescending();
    }
    interface Iadd
    {
        void Add();
    }
    interface Ifindbyname
    {
        void Findbyname();
    }
    interface Idefinetherank
    {
        void Definetherank();
    }
    class DeclareFunction :  Ifindgreatestsalary, Ifindtotalsalary, Iremove, Isort, Iadd, Ifindbyname, Idefinetherank
    {
        protected List<Employee> ListofEmployee;
        protected List<Employee> InternalList;
        public delegate void Excecute(); //delegate
        public DeclareFunction()
        {
            ListofEmployee = new List<Employee>();
            InternalList = new List<Employee>(); //list tạm thời
        }
        public DeclareFunction(List<Employee> listofemployee, List<Employee> internallist)
        {
            this.ListofEmployee = listofemployee;
            this.InternalList = internallist;
        }
        public void InputListofEmployee()
        {
            Console.WriteLine("*********************");
            int numofretailer;
            Console.WriteLine("Type the number of retailer:");
            numofretailer = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numofretailer; i++)
            {
                Employee e1 = new Retailer();
                ListofEmployee.Add(e1);

            }
            int numoftelephonist;
            Console.WriteLine("Type the number of Telephonist:");
            numoftelephonist = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numoftelephonist; i++)
            {
                Employee e2 = new Telephonist();
                ListofEmployee.Add(e2);

            }
            int numofguard;
            Console.WriteLine("Type the number of Guard:");
            numofguard = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < numofguard; i++)
            {
                Employee e3 = new Guard();
                ListofEmployee.Add(e3);

            }
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            foreach (Employee e in ListofEmployee)
            {
                e.InputinformationofEmployee();
            }
            Console.WriteLine("*********************");
            Console.WriteLine("*********************");
            foreach (Employee e in ListofEmployee)
            {
                e.OutputinformationofEmployee();
            }
            Console.WriteLine("*********************");
        }
        public Employee Employeewithmaxsalary()
        {
            Employee max = this.ListofEmployee[0];
            for (int i = 0; i < ListofEmployee.Count; i++)
            {
                if (max.salary < ListofEmployee[i].salary)
                {
                    max = ListofEmployee[i];
                }
            }
            return max;
        }
        public void Employeewithgreatestsalary()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Employee with highest salary is");
            Employeewithmaxsalary().OutputinformationofEmployee();
            Console.WriteLine("*********************");
        }
        public void Findtotalsalary()
        {
            Console.WriteLine("*********************");
            double sum = 0;
            for (int i = 0; i < ListofEmployee.Count; i++)
            {
                sum += ListofEmployee[i].salary;
            }
            Console.WriteLine("Sum of all employee in store:" + sum);
            Console.WriteLine("*********************");
        }
        public void Remove()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Type the employee id need to delete:");
            string tmp = Console.ReadLine();
            for (int i = 0; i < ListofEmployee.Count; i++)
            {
                if (tmp == ListofEmployee[i].ID)
                {
                    int vitri = i;
                    Console.WriteLine("Proceed to remove that employee");
                    ListofEmployee.RemoveAt(vitri);
                }
            }
            var newlist = ListofEmployee.OrderByDescending(e => e.salary).ToList();
            Console.WriteLine("List after removing:");
            foreach (Employee e in newlist)
            {
                e.OutputinformationofEmployee();
            }
            Console.WriteLine("*********************");
        }
        public void Sortdescending()
        {
            Console.WriteLine("*********************");
            var newlist = ListofEmployee.OrderByDescending(e => e.salary).ToList();
            Console.WriteLine("List after sorting:");
            foreach (Employee e in newlist)
            {
                e.OutputinformationofEmployee();
            }
            Console.WriteLine("*********************");
        }
        public void Add()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Type the information of employee want to add into list:");
            Employee e4 = new Guard();
            e4.InputinformationofEmployee();
            InternalList.Add(e4);
            ListofEmployee.AddRange(InternalList);
            //var newlist = ListofEmployee.Concat(new[] { e4 }).ToList();
            Console.WriteLine("List after adding:");
            foreach (Employee e in ListofEmployee)
            {
                e.OutputinformationofEmployee();
            }
            Console.WriteLine("*********************");
        }
        public void Findbyname()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Type the name of employee:");
            string tmp = Console.ReadLine();
            for (int i=0; i<ListofEmployee.Count; i++)
            {
                if(tmp == ListofEmployee[i].NAME)
                {
                    Console.WriteLine("Information of that employee:");
                    ListofEmployee[i].OutputinformationofEmployee();
                }
            }
            Console.WriteLine("*********************");
        }
        public void Definetherank()
        {
            Console.WriteLine("*********************");
            Console.WriteLine("Rank of each employee");   
            for (int i=0; i<ListofEmployee.Count; i++)
            {
                if(ListofEmployee[i].numberofworkday <30)
                {
                    Console.WriteLine(ListofEmployee[i].NAME);
                    Console.WriteLine(ListofEmployee[i].rank = "Bad");
                }
                else if(ListofEmployee[i].numberofworkday <= 60)
                {
                    Console.WriteLine(ListofEmployee[i].NAME);
                    Console.WriteLine(ListofEmployee[i].rank = "Good");
                }
                else if (ListofEmployee[i].numberofworkday >100)
                {
                    Console.WriteLine(ListofEmployee[i].NAME);
                    Console.WriteLine(ListofEmployee[i].rank = "Excellent");
                }
            }
            Console.WriteLine("*********************");
        }
        public static void Execute()
        {
            Console.WriteLine("*********************");
            DeclareFunction d = new DeclareFunction();
            Excecute e = new Excecute(d.InputListofEmployee); //áp dụng delagate để nguyên đống này excute 1 lần duy nhất
            e += d.Add; //add ở đây để có list mới thì nó execute theo list mới luôn
            e += d.Definetherank;
            e += d.Employeewithgreatestsalary;
            e += d.Findbyname;
            e += d.Findtotalsalary;
            e += d.Sortdescending;
            e += d.Remove;
            e.Invoke(); //chạy delegate
            Console.WriteLine("*********************");
        }
    }
}
