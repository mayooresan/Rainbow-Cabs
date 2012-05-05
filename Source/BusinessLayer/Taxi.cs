using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BusinessLayer
{
    public class Taxi
    {
        public String addTaxi()
        {
            return "Taxi Added";
        }
        public void WriteHtml(String Maps)
        {
            string htmlDocument = @"<html><body><img src=" + Maps + "></body></html>";
            try
            {
                FileStream fs = File.OpenWrite(@"d:\myMap.html");
                StreamWriter writer = new StreamWriter(fs, Encoding.UTF8);
                writer.Write(htmlDocument);
                writer.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
