using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string metin = textBox1.Text;

            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(metin, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode=new QRCode(qRCodeData);
            Bitmap qrcodeimage = qRCode.GetGraphic(30);
            pictureBox1.Image = qrcodeimage;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
