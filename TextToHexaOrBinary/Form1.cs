using System;
using System.Windows.Forms;

namespace TextToHexaOrBinary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void ToBinary_Click(object sender, EventArgs e)
        {
            Wynik.Text=BinaryClass.TextToBinary(Text.Text);
        }
    }
}
