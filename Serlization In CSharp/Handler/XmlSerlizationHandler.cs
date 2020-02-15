using Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Handler
{
    public class XmlSerlizationHandler
    {
        List<PersonInf> personInfs = new List<PersonInf>();
        public  XmlSerializer xmlSerializer;
        public XmlSerlizationHandler()
        {
            xmlSerializer = new XmlSerializer(typeof(List<PersonInf>));
        }

        public void Serlization(string path,List<PersonInf> personInfs)
        {
            StreamWriter streamWriter=null;

            try
            {
                streamWriter = new StreamWriter(path + DateTime.Now.Ticks.ToString() + ".xml");
                xmlSerializer.Serialize( streamWriter,personInfs);
                Console.WriteLine("Serlization Completed ");
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (streamWriter != null)
                {
                    streamWriter.Dispose();
                }
            }

        }
    }
}
