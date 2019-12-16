using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjectOOP
{
    interface Inputlistofcustomer
    {
        void InputListofCustomer();
    }
    interface IOutputlistofcustomer
    {
        void OutputlistofCustomer();
    }
    class GetListCustomer :Inputlistofcustomer, IOutputlistofcustomer
    {
        protected List<Customer> ListofCustomer;
        public GetListCustomer()
        {
            ListofCustomer = new List<Customer>();
        }
        public GetListCustomer(List<Customer> listofcustomer)
        {
            this.ListofCustomer = listofcustomer;
        }
        public  virtual void InputListofCustomer()
        { 
            var alllines = File.ReadAllLines(@"E:\Customer.txt");
            foreach (var line in alllines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofCustomer.Add(new Customer { CUStomername = splitline[0], PHOnenumber = splitline.Length > 1 ? splitline[1] : null, MONeyspent = splitline.Length > 2 ? splitline[2] : null, NAMEofproductbought = splitline.Length > 3 ? splitline[3] : null, SERIALnumberofproductbought = splitline.Length > 4 ? splitline[4] : null });
                }
            }
        }
        public void OutputlistofCustomer()
        {
            foreach (Customer c in ListofCustomer)
            {
                c.Outputinformation();
            }
        }
    }
}
