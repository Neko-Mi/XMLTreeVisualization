using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XMLTreeVisualization
{
    class Download
    {
        /// <summary>
        /// Downloading XML file from url
        /// </summary>
        /// <param name="filePath">Path to XML file</param>
        /// <param name="url">URL-link to XML file</param>
        public void DownloadXML(String filePath, String url)
        {
            WebClient webClient = new WebClient();
            webClient.DownloadFile(url, filePath);
        }

        /// <summary>
        /// Checking XML file on correct
        /// </summary>
        /// <param name="filePath">Path to XML file</param>
        public void CheckXML(String filePath)
        {
            XDocument doc = new();
            try
            {
                doc = XDocument.Load(filePath);
            }
            catch (Exception e)
            {
                MessageBox.Show("XML are not correct");
            }
        }
    }
}
