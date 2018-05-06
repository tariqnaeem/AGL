using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PurchaseOrderLine
    {
        private string lineNumber;
        private string productDesc;
        private string orderQty;
        

        //Getters & Setters

        public void setlineNumber(string lineNumber)
        {
            this.lineNumber = lineNumber;
        }

        public string getLineNumber()
        {
            return this.lineNumber;
        }

        public void setProductDesc(string productDesc)
        {
            this.productDesc = productDesc;
        }

        public string getProductDesc()
        {
            return this.productDesc;
        }

        public void setOrderQty(string orderQty)
        {
            this.orderQty = orderQty;
        }

        public string getOrderQty()
        {
            return this.orderQty;
        }
    }
}
