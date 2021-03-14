using Base64Encoding.Core;
using System;
using System.Text;
using System.Windows.Forms;

namespace Base64Encoding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonEncode_Click(object sender, EventArgs e)
        {
            var bytes = Encoding.Default.GetBytes(richTextBoxInput.Text);
            var encodedString = Base64.Encode(bytes);
            richTextBoxOutput.Text = encodedString;
        }

        private void ButtonDecode_Click(object sender, EventArgs e)
        {
            var str = richTextBoxInput.Text;
            var decodedBytes = Base64.Decode(str);
            richTextBoxOutput.Text = Encoding.Default.GetString(decodedBytes);
        }
    }
}