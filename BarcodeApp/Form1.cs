using System;
using System.Drawing;
using System.Drawing.Imaging;
using BarcodeLib;
using ZXing;
using System.Windows.Forms;

namespace BarcodeApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BarcodeGenerator barcodeGenerator = new BarcodeGenerator();
            Bitmap barcode = barcodeGenerator.GenerateBarcode(textBox1.Text, BarcodeFormat.CODE_128, 350, 150);
            pictureBox1.Image = barcode;
        }
    }
}
