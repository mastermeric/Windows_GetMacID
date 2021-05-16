using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.NetworkInformation;

namespace getMacId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "MAC-ID ekranı";       
                
        }


        private void button1_Click(object sender, EventArgs e)
        {
            NetworkInterface[] networkInterfaces = NetworkInterface.GetAllNetworkInterfaces();

            if (null == networkInterfaces || networkInterfaces.Length == 0)
            {
                label1.Text = "Mac Id Alınamadı!!!";
               // MessageBox.Show("Mac Id Alınamadı!!!");
            }

            label1.Text = "MAC Adresi: " + NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString();
            //MessageBox.Show(NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().ToString());
            //NetworkInterface.GetAllNetworkInterfaces()[0].GetPhysicalAddress().GetAddressBytes();
        }

    }
}
