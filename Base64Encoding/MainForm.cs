using Base64Encoding.Core;
using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Base64Encoding
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            toolStripMenuItemEncode.Click += ToolStripMenuItemEncode_Click;
            toolStripMenuItemDecode.Click += ToolStripMenuItemDecode_Click;
        }

        private void ToolStripMenuItemDecode_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select file to Decode from Base64";            
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            saveFileDialog.Title = "Select path to save decoded file";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using (var reader = new StreamReader(openFileDialog.OpenFile()))
            using (var writer = saveFileDialog.OpenFile())
            {
                var buffer = Base64.Decode(reader.ReadToEnd());
                writer.Write(buffer, 0, buffer.Length);                
            }

            MessageBox.Show("File success decoded.", "Decoding", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ToolStripMenuItemEncode_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Select file to Encode it to Base64";
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            saveFileDialog.Title = "Select path to save encoded file";
            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            using (var reader = openFileDialog.OpenFile())
            using (var writer = new StreamWriter(saveFileDialog.OpenFile()))
            {
                var buffer = new byte[1024 * 4];
                int readCount;

                while (reader.Position < reader.Length)
                {
                    readCount = reader.Read(buffer, 0, buffer.Length);
                    
                    if (readCount < buffer.Length)
                    {
                        writer.Write(Base64.Encode(buffer[0..readCount]));
                    }
                    else
                    {
                        writer.Write(Base64.Encode(buffer));
                    }
                }                                                
            }

            MessageBox.Show("File success encoded.", "Encoding", MessageBoxButtons.OK, MessageBoxIcon.Information);

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