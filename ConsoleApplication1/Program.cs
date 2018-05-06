using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Collections.Specialized;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger = Logger.Instance; //Singleton Design Pattern implemention
            try
            {
                string filePath = ConfigurationManager.AppSettings.Get("SrcFilePath");
                
                foreach (string fileName in Directory.GetFiles(filePath))
                {
                        var reader = File.ingest(fileName);
                        if (reader != null)
                        {
                            //Factory Design Pattern implementation
                            logger.log("Start Processing ....");
                            reader.processFile();
                            logger.log("End Processing ....");
                        }
                }
            }
            catch (Exception e)
            {
                logger.log(e.ToString());
            }
            
        }
    }
}
