using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Configuration;
namespace ConsoleApplication1
{
    class XMLGenerator
    {
        XmlTextWriter writer;

        public XMLGenerator(){

            this.writer = new XmlTextWriter(ConfigurationManager.AppSettings.Get("DestFilePath"), System.Text.Encoding.UTF8);
            this.writer.WriteStartDocument(true);
            this.writer.Formatting = Formatting.Indented;
            this.writer.Indentation = 2;
            this.writer.WriteStartElement("PurchaseOrders");
            
        }
        //create Purchase order element in xml
        public void createPurchaseOrder(PurchaseOrder po)
        {
            writer.WriteStartElement("PurchaseOrder");
          
            writer.WriteStartElement("CustomerPo");
            writer.WriteString(po.getCustomerPro());
            writer.WriteEndElement();          

            writer.WriteStartElement("Supplier");
            writer.WriteString(po.getSupplier());
            writer.WriteEndElement();
     
            writer.WriteStartElement("Origin");
            writer.WriteString(po.getOrigin());
            writer.WriteEndElement();

            writer.WriteStartElement("Destination");
            writer.WriteString(po.getDestination());
            writer.WriteEndElement();

            writer.WriteStartElement("CargoReady");
            writer.WriteString(po.getCargoReady());
            writer.WriteEndElement();
        }

        //create lines element
        public void createLines()
        {
            writer.WriteStartElement("Lines");
        }
        //end XML elements
        public void endDocument()
        {
            writer.WriteEndDocument();
            writer.Close();
        }
        

        public void createPurchaseOrderLines(PurchaseOrderLine pol)
        {

            writer.WriteStartElement("PurchaseOrderLine");

            writer.WriteStartElement("LineNumber");
            writer.WriteString(pol.getLineNumber());
            writer.WriteEndElement();
            
           
            writer.WriteStartElement("ProductDescription");
            writer.WriteString(pol.getProductDesc());
            writer.WriteEndElement();

            
            writer.WriteStartElement("OrderQty");
            writer.WriteString(pol.getOrderQty());
            writer.WriteEndElement();

            endElement();
        }

        public void endElement()
        {
            writer.WriteEndElement();
        }
    }
}
