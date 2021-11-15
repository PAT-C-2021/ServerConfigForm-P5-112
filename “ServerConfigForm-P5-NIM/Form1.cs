using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using ServiceMtk_P1_20190140112;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ServerConfigForm_P5_NIM
{
    public partial class Form1 : Form
    {
        private ServiceHost Host;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnON_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            labelOnorOff.Text = "Server On";
            labelKet.Text = "Klik Off untuk Mematikan Server";
            Host.Open();
            btnON.Enabled = false;
            btnOff.Enabled = true;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            btnON.Enabled = true;
            btnOff.Enabled = false;
            Host.Close();
            labelKet.Text = "Klik On untuk menjalani server";
            labelOnorOff.Text = "Server Off";
        }
    }
}
