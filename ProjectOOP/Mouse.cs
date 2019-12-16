using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectOOP
{
    class Mouse :Product
    {
        protected string Quality;
        public string qUality
        {
            get { return this.Quality; }
            set { this.Quality = value; }
        }
        public Mouse () :base()
        {

        }
        public Mouse(string Nameofproduct, string SeRialnumber, string TYPE, string PRICE, string quality) : base(Nameofproduct, SeRialnumber, TYPE, PRICE)
        {
            this.Quality = quality;
        }
        public override void OutputlistofProduct()
        {
            base.OutputlistofProduct();
            Console.WriteLine("Quality: " + this.Quality);
        }
    }
}
