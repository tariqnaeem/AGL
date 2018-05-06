using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication1
{
    class CSVReader : Reader
    {
        private string csvData;
        public CSVReader(string filePath){

            //Read the contents of CSV file.  
            csvData = System.IO.File.ReadAllText(filePath);  
        
        }
        
        //process a file
        public override void processFile()
        {

            XMLGenerator xml = new XMLGenerator();
            //Execute a loop over the rows. 
            bool lines = false;

            foreach (string row in csvData.Split('\r'))
            {
                if (!string.IsNullOrEmpty(row))
                {

                    //Execute a loop over the columns.

                    string[] element = row.Split(',');


                    int result;
                    if (Int32.TryParse(element[2], out result))
                    {
                        PurchaseOrderLine pol = new PurchaseOrderLine();

                        pol.setlineNumber(element[2]);
                        pol.setProductDesc(element[3]);
                        pol.setOrderQty(element[4]);
                        if (!(lines))
                        {
                            xml.createLines();
                            lines = true;
                        }

                        xml.createPurchaseOrderLines(pol);
                    }
                    else
                    {
                        if (lines)
                        {
                            lines = false;
                            xml.endElement();//lines element
                            xml.endElement();//purchase Order element
                        }

                        PurchaseOrder po = new PurchaseOrder();
                        po.setCustomerPro(element[1]);
                        po.setSupplier(element[2]);
                        po.setOrigin(element[3]);
                        po.setDestination(element[4]);
                        po.setCargoReady(element[5]);

                        xml.createPurchaseOrder(po);
                    }
                }
            }
            xml.endElement();//purchase orders
            xml.endDocument();
        }
    }
}
