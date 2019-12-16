using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjectOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int key;
            while (true)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("--------COMPUTER STORE MANAGEMENT--------");
                Console.WriteLine("--------------make with admin rights only");
                Console.WriteLine("1. Input and output information of employee and make adjustment on list employee:");
                Console.WriteLine("2. Execute all of functionalites by appplying new list:"); // đáng lẽ cái case 2 này bỏ chung case 1 dc nhưng nó lại ko chạy như ý muốn
                Console.WriteLine("3. Display the list of Product from a file");
                Console.WriteLine("4. Display the list of Customer from a file");
                Console.WriteLine("5. Modify between Product and Customer   ");
                Console.WriteLine("6. Record all information of Customer and store in a file for security");
                Console.WriteLine("7. Exit the Application");
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("----------Please make a choice-----------");

                key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("You have choose option 1:");
                        DeclareFunction d = new DeclareFunction();
                        d.InputListofEmployee();
                        int keycase2;
                        Console.WriteLine("Please choose another option to perform adjustment in employee information");
                        Console.WriteLine("1. Add another employee into list");
                        Console.WriteLine("2. Find employee with greatest salary");
                        Console.WriteLine("3. Find total salary of all employee");
                        Console.WriteLine("4. Remove any employee");
                        Console.WriteLine("5. Sort the employee in descending order base on their salary");
                        Console.WriteLine("6. Find the information of the employee by his name");
                        Console.WriteLine("7. Define the rank of the employee");
                        Console.WriteLine("8. Exit");
                        keycase2 = Convert.ToInt32(Console.ReadLine());
                        switch (keycase2)
                        {
                            case 1:
                                Console.WriteLine("You have choose to add another employee into list");

                                    d.Add();
                                    break;

                            case 2:
                                Console.WriteLine("You have choose to find the employee with highest salary");
                                    d.Employeewithgreatestsalary();
                                break;
                            case 3:
                                Console.WriteLine("You have choose to find the total salary of all employee");
                                    d.Findtotalsalary();
                                    break;
                            case 4:
                                Console.WriteLine("You have choose to remove any employee");
                                    d.Remove();
                                    break;
                            case 5:
                                Console.WriteLine("You have choose to sort the employee in descending order");
                                    d.Sortdescending();
                                    break;
                            case 6:
                                Console.WriteLine("You have choose to find the employee information by this name");
                                    d.Findbyname();
                                    break;
                            case 7:
                                Console.WriteLine("You have choose to define the rank of each employee");
                                    d.Definetherank();
                                    break;
                            case 8:
                                {
                                    Console.WriteLine("Exit option 1");
                                    break;
                                }
                        }
                        break;
                    case 2:
                        Console.WriteLine("You have choose option 2");
                        Console.WriteLine("You choose to peform all operation above");
                        DeclareFunction.Execute();
                        break;
                    case 3:
                        Console.WriteLine("You have choose option 3");
                        GetListProduct gp = new GetListProduct();
                        gp.Inputlistofproduct();
                        Console.WriteLine("Get information sucessfully!");
                        gp.OutputlistofProduct();
                        break;
                    case 4:
                        Console.WriteLine("You have choose option 4");
                        GetListCustomer gc = new GetListCustomer();
                        gc.InputListofCustomer();
                        Console.WriteLine("Get information sucessfully!");
                        gc.OutputlistofCustomer();
                        break;
                    case 5:
                        Console.WriteLine("You have choose option 5");
                        ListofCustomerandListofProudctModification l = new ListofCustomerandListofProudctModification();
                        l.Inputlistofproduct(); // phải có 2 cái input này mới chạy dc ko hiểu sao :D hay do cùng class
                        l.InputListofCustomer();
                        Console.WriteLine("Please choose another option to perform more adjustment on product and customer");
                        int keycase3;
                        Console.WriteLine("1. Find the exchange of each customer after they have bought the product");
                        Console.WriteLine("2. Find the information of the customer based on their name");
                        Console.WriteLine("3. Find the customer with highest money spent");
                        Console.WriteLine("4. Exit option 5");
                        keycase3 = Convert.ToInt32(Console.ReadLine());
                    switch(keycase3)
                        {
                            case 1:
                                Console.WriteLine("You have choose option 1");
                                l.Findexchange();
                                break;
                            case 2:
                                Console.WriteLine("You have choose option 2");
                                l.Findexchange();
                                break;
                            case 3:
                                Console.WriteLine("You have choose option 3");
                                l.Maxmoneyspent();
                                break;
                            case 4:
                                break;
                        }
                        break;
                    case 6:
                        Console.WriteLine("You have choose option 6");
                        Record r = new Record();
                        r.InputListofCustomer();
                        Console.WriteLine("All data have been transfer into bin file");
                        Console.WriteLine("Please check in the specific folder described");
                        break;
                    case 7:
                        Console.WriteLine("Exit Application");
                        return;
                }
            }
        }
    }
}
