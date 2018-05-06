using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
namespace ConsoleApplication1
{
    class Logger
    {
        private static StreamWriter file = null;
        private static Logger logger = null;
        private string logFile = ConfigurationManager.AppSettings.Get("LogPath");
        private Logger() {  }
        public static Logger Instance
        {
            get 
              {
                 if (logger == null)
                 {
                     logger = new Logger();
                    
                 }
                 return logger;
              }
        }

        public void log(string message)
        {
            using (StreamWriter w = System.IO.File.AppendText(logFile)) ;
            System.IO.File.AppendAllText(logFile, Environment.NewLine + DateTime.Now + " - " + message);
        }

    }
}
