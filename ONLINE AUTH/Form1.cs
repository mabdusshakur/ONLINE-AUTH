using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ONLINE_AUTH
{
    public partial class Form1 : Form
    {
        WebClient WebClient = new WebClient();
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Active_TB_Click(object sender, EventArgs e)
        {
            string serverLicense = WebClient.DownloadString("https://onlinelicensetest.000webhostapp.com/license");
            if (License_TB.Text == serverLicense)
            {
                MessageBox.Show("License Activated");
            }
            else MessageBox.Show("License failed");
        }
    }
}
