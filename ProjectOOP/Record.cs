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
    class Record : GetListCustomer
    {
        public Record() :base()
            {
            ListofCustomer = new List<Customer>();
            
        }
        public Record(List<Customer> listofcustomer) :base (listofcustomer)
        {

        }
        public override void InputListofCustomer()
        {
            base.InputListofCustomer();
            string pathsave = @"D:\";
            string serializationFile = Path.Combine(pathsave, "CUSTOMER.bin");
            using (Stream stream = File.Open(serializationFile, FileMode.Create))
            {
                var fformatter = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                fformatter.Serialize(stream, ListofCustomer);
            }
        }
    }
}
