using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace ConsoleApplication1
{
    static class File
    {
        //File type verification
        public static Reader ingest(string filePath)
        {
           if (Path.GetExtension(@filePath) == ".csv") 
           {
                return new CSVReader(filePath);
           }
           else
           {
                return null;
           }
        }
    }
}
