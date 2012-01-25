using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Web.Script.Serialization;
using System.Net;

namespace Rainbow_Cabs
{
    public partial class CabLocation : Form
    {
        public CabLocation()
        {
            InitializeComponent();

        }

        private void buttonRefreshLocation_Click(object sender, EventArgs e)
        {
            var userId = "NO UserID";// = "579295285979160295";

            BusinessLayer.Driver DriveO = new BusinessLayer.Driver();
            userId = DriveO.getGoogleID();

            // Url of the JSON Latitude feed
            var url = String.Format("http://www.google.com/latitude/apps/badge/api?user={0}&type=json", userId);

            // We download the file
            var ms = new MemoryStream();
            Download(url, ms);

            // JSON in text format
            var textContent = UTF8Encoding.UTF8.GetString(ms.ToArray());

            // We convert the JSON text file to an object
            // It returns 
            var jss = new JavaScriptSerializer();
            var jsonContent = jss.DeserializeObject(textContent) as Dictionary<String, Object>;

            // We get the data
            try
            {

                var features = (jsonContent["features"] as object[])[0] as Dictionary<string, object>;
                var geometry = features["geometry"] as Dictionary<string, object>;
                var coordinates = geometry["coordinates"] as object[];
                var lon = coordinates[0] as decimal?;
                var lat = coordinates[1] as decimal?;

                // And then the timestamp
                var properties = features["properties"] as Dictionary<string, object>;
                var date = ConvertFromUnixTimestamp((double)(int)properties["timeStamp"]);

                // We convert the UTC date to local time
                date = date.ToLocalTime();

                Console.WriteLine("{0} : {1} x {2}", date, lat, lon);

                //txtLatitute.Text = lat.ToString();
                //txtLongitute.Text = lon.ToString();

                String locationString = @"http://maps.google.com/maps/api/staticmap?center=" + lat.ToString() + "," + lon.ToString() + "&zoom=14&size=250x250&maptype=roadmap&markers=color:red%7Clabel:S%7C" + lat.ToString() + "," + lon.ToString() + "&sensor=false";

                BusinessLayer.Taxi loc = new BusinessLayer.Taxi();
                loc.WriteHtml(locationString);
                webBrowser1.Url = new Uri(@"d:\myMap.html");

                labelDate.Text = date.ToString("yyyy-MM-dd HH:MM");  
            }
            catch (Exception ex)
            {
                MessageBox.Show("System unable to find current location! Please connect to Internet and try again.");
            }
        }

        public static DateTime ConvertFromUnixTimestamp(double timestamp)
        {
            DateTime origin = new DateTime(1970, 1, 1, 0, 0, 0, 0);
            return origin.AddSeconds(timestamp);
        }

        private const int BUFFER_SIZE = 1024;

        private static void Download(string url, Stream writeStream)
        {


            try
            {
                var request = (HttpWebRequest)WebRequest.Create(url);
                var response = request.GetResponse();
                var readStream = response.GetResponseStream();
                var data = new Byte[BUFFER_SIZE];

                int n;
                do
                {
                    n = readStream.Read(data, 0, BUFFER_SIZE);
                    writeStream.Write(data, 0, n);
                } while (n > 0);

                writeStream.Flush();
                readStream.Close();
            }
            catch (Exception ex)
            {
               // MessageBox.Show("Connect to Internet to fetch the location Details!");

            }
            finally
            {

            }
        }
    }
}
