using System;
using System.Windows.Forms;

namespace TextToHexaOrBinary
{
    public partial class ToHexOrBin : Form
    {
        public ToHexOrBin()
        {
            InitializeComponent();
        }
        private void ToBinary_Click(object sender, EventArgs e)
        {
            Result.Text=BinaryClass.TextToBinary(TextToConv.Text);
        }
        private void ToHexa_Click(object sender, EventArgs e)
        {
            Result.Text = HexClass.TextToBinary(TextToConv.Text);
        }
    }
}
