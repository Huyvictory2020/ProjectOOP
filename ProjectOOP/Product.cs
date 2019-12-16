using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    interface Ioutputproduct
    {
        void OutputlistofProduct();
    }
    class Product : Ioutputproduct
    {
        protected string NameofProduct;
        protected string Serialnumber;
        protected string Type;
        protected string Price;
        public string nameofproduct
        {
            get { return this.NameofProduct; }
            set { this.NameofProduct = value; }
        }
        public string serialnumber
        {
            get { return this.Serialnumber; }
            set { this.Serialnumber = value; }
        }
        public string type
        {
            get { return this.Type; }
            set { this.Type = value; }
        }
        public string price
        {
            get { return this.Price; }
            set { this.Price = value; }
        }
        public Product()
        {

        }
        public Product(string Nameofproduct, string SeRialnumber, string TYPE, string PRICE)
        {
            this.NameofProduct = Nameofproduct;
            this.Serialnumber = SeRialnumber;
            this.Type = TYPE;
            this.Price = PRICE;
        }
      public virtual void OutputlistofProduct()
        {
            Console.WriteLine("Name of Product: " + this.NameofProduct);
            Console.WriteLine("Serial Number: " + this.Serialnumber);
            Console.WriteLine("Type: " + this.Type);
            Console.WriteLine("Price: " + this.Price);
        }
    }
}
