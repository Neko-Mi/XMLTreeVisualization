using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XMLTreeVisualization
{
    public partial class MainForm : Form
    {
        private String filePath = "./xml.xml"; // Path where saving xml file

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_download_Click(object sender, EventArgs e)
        {
            String url = textBox_link.Text;
            Download download = new();
            download.DownloadXML(this.filePath, url);
            download.CheckXML(this.filePath);
        } 

        private void button_visualization_Click(object sender, EventArgs e)
        {
            Visualization visualization = new();
            visualization.Visualize(treeView1, this.filePath);
        }
        
    }
}
