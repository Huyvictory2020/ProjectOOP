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
    interface outputinfo
    {
        void Outputinformation();
    }
    [Serializable] //để tạo ra file
    class Customer :  outputinfo
    {
        protected string CustomerName;
        protected string PhoneNumber;
        protected string MoneySpent;
        protected string NameofProductbought;
        protected string SerialNumberofproductbought;
        public string CUStomername
        {
            get { return this.CustomerName; }
            set { this.CustomerName = value; }
        }
        public string PHOnenumber
        {
            get { return this.PhoneNumber; }
            set { this.PhoneNumber = value; }
        }
        public string MONeyspent
        {
            get { return this.MoneySpent; }
            set { this.MoneySpent = value; }
        }
        public string NAMEofproductbought
        {
            get { return this.NameofProductbought; }
            set { this.NameofProductbought = value; }
        }
        public string SERIALnumberofproductbought
        {
            get { return this.SerialNumberofproductbought; }
            set { this.SerialNumberofproductbought = value; }
        }

        public Customer() 
            {

            }
        public Customer(string customername, string phonenumber, string moneyspent, string nameofproductbought, string serialnumberofproductbought) 
        {
            this.CustomerName = customername;
            this.PhoneNumber = phonenumber;
            this.MoneySpent = moneyspent;
            this.NameofProductbought = nameofproductbought;
            this.SerialNumberofproductbought = serialnumberofproductbought;
        }
        public void Outputinformation()
        {
            Console.WriteLine("Customer Name: " + this.CustomerName);
            Console.WriteLine("Phone number: " + this.PhoneNumber);
            Console.WriteLine("Money Spent: " + this.MoneySpent);
            Console.WriteLine("Name of product bought: " + this.NameofProductbought);
            Console.WriteLine("Serial Number of Product bought: " + this.SerialNumberofproductbought);
        }
    }
}
