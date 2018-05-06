using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Globalization;

namespace ConsoleApplication1
{
    class PurchaseOrder
    {
        private string customerPo;
        private string supplier;
        private string origin;
        private string destination;
        private string cargoReady;

        //Getters & Setters
       
        public void setCustomerPro(string customerPro){
            this.customerPo = customerPro;
        }

        public string getCustomerPro()
        {
            return this.customerPo;
        }

        public void setSupplier(string supplier)
        {
            if (supplier == "SHANGHAI FURNITURE COMPANY")
            {
                this.supplier = "SFC01";
            }
            else if(supplier == "YANTIAN INDUSTRIAL PRODUCTS")
            {
                this.supplier = "YIP-1";
            }
        }

        public string getSupplier()
        {
            return this.supplier;
        }

        public void setOrigin(string origin)
        {
            this.origin = origin;
        }

        public string getOrigin()
        {
            return this.origin;
        }

        public void setDestination(string destination)
        {
            this.destination = destination;
        }

        public string getDestination()
        {
            return this.destination;
        }

        public void setCargoReady(string cargoReady)
        {

            DateTime dt;
            if (DateTime.TryParse(cargoReady, out dt))
            {
                string format = "yyyy/MM/dd";
                this.cargoReady = dt.ToString(format);
            }
            else
            {
                Console.WriteLine("Not a valid datetime");
            }
            //this.cargoReady = DateTime.ParseExact(cargoReady, "yy/MM/dd", CultureInfo.InvariantCulture);
        }

        public string getCargoReady()
        {
            return this.cargoReady.ToString();
        }
    }
}
