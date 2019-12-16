using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Keyboard : Product
    {
        protected string Color;
        public string COlor
        {
            get { return this.Color; }
            set { this.Color = value; }
        }
        public Keyboard() :base()
        {

        }
        public Keyboard(string Nameofproduct, string SeRialnumber, string TYPE, string PRICE, string color) : base(Nameofproduct, SeRialnumber, TYPE, PRICE)
        {
            this.Color = color;
        }
        public override void OutputlistofProduct()
        {
            base.OutputlistofProduct();
            Console.WriteLine("Color: " + this.Color);
        }
    }
}
