using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ProjectOOP
{
    interface inputlistofproduct
    {
        void Inputlistofproduct();
    }
    interface outputlistproduct
    {
        void OutputlistofProduct();
    }
    class GetListProduct :inputlistofproduct, outputlistproduct
    {
        protected List<Product> ListofProduct;
        public GetListProduct()
        {
            ListofProduct = new List<Product>();
        }
        public GetListProduct(List<Product> listofproduct)
        {
            this.ListofProduct = listofproduct;
        }
        public  void Inputlistofproduct()
        {
            var threefirstlines = File.ReadLines(@"E:\Product.txt").Take(3);
            foreach(var line in threefirstlines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofProduct.Add(new Computer { nameofproduct = splitline[0], serialnumber = splitline.Length > 1 ? splitline[1] : null, type = splitline.Length > 2 ? splitline[2] : null, price = splitline.Length > 3 ? splitline[3] : null, cPu = splitline.Length > 4 ? splitline[4] : null });
                }
            }
            var threenextlines = File.ReadLines(@"E:\Product.txt").Skip(3).Take(3);
            foreach (var line in threenextlines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofProduct.Add(new Mouse { nameofproduct = splitline[0], serialnumber = splitline.Length > 1 ? splitline[1] : null, type = splitline.Length > 2 ? splitline[2] : null, price = splitline.Length > 3 ? splitline[3] : null, qUality = splitline.Length > 4 ? splitline[4] : null });
                }
            }
            var lastthreelines = File.ReadLines(@"E:\Product.txt").Skip(6).Take(3);
            foreach (var line in lastthreelines)
            {
                var splitline = line.Split(new[] { ',' });
                if (splitline != null && splitline.Any())
                {
                    ListofProduct.Add(new Keyboard { nameofproduct = splitline[0], serialnumber = splitline.Length > 1 ? splitline[1] : null, type = splitline.Length > 2 ? splitline[2] : null, price = splitline.Length > 3 ? splitline[3] : null, COlor = splitline.Length > 4 ? splitline[4] : null });
                }
            }
        }
        public void OutputlistofProduct()
        {
            foreach (Product p in ListofProduct)
            {
                p.OutputlistofProduct();
            }
        }
    }
}
