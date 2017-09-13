using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.Models
{
    class Logers
    {
        string logPath = ".\\logging.log";

        public Logers()
        {

        }

        public void WriteLog(string nameMethod, string exeptionString)
        {
            try
            {
                StreamWriter w = new StreamWriter(this.logPath, true);
                w.WriteLine("{0}/{1} - В {2} произашел сбой :", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString(), nameMethod);
                w.WriteLine("{0}", exeptionString);
                w.WriteLine("##########################################################################################################");
                w.Close();
            }
            catch
            {

            }
        }
    }

    class EventLogers
    {
        string Path = ".\\event.log";

        public EventLogers()
        {

        }

        public void WriteEventLog(string Events)
        {
            try
            {
                StreamWriter w = new StreamWriter(this.Path, true);
                w.WriteLine("{0}/{1} - {2}", DateTime.Now.ToLongDateString(), DateTime.Now.ToLongTimeString(), Events);
                w.WriteLine("##################################");
                w.Close();
            }
            catch
            {

            }
        }
    }
}
