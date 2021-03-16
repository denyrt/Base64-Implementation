
namespace Base64Encoding
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxInput = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButtonFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripMenuItemEncode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemDecode = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxInput
            // 
            this.richTextBoxInput.Location = new System.Drawing.Point(12, 83);
            this.richTextBoxInput.Name = "richTextBoxInput";
            this.richTextBoxInput.Size = new System.Drawing.Size(758, 174);
            this.richTextBoxInput.TabIndex = 0;
            this.richTextBoxInput.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Output:";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 281);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.ReadOnly = true;
            this.richTextBoxOutput.Size = new System.Drawing.Size(758, 174);
            this.richTextBoxOutput.TabIndex = 2;
            this.richTextBoxOutput.Text = "";
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(664, 464);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(94, 29);
            this.buttonEncode.TabIndex = 4;
            this.buttonEncode.Text = "Encode";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.ButtonEncode_Click);
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(564, 464);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(94, 29);
            this.buttonDecode.TabIndex = 5;
            this.buttonDecode.Text = "Decode";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.ButtonDecode_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButtonFile});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(782, 27);
            this.toolStrip.TabIndex = 6;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripDropDownButtonFile
            // 
            this.toolStripDropDownButtonFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemEncode,
            this.toolStripMenuItemDecode});
            this.toolStripDropDownButtonFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButtonFile.Image")));
            this.toolStripDropDownButtonFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButtonFile.Name = "toolStripDropDownButtonFile";
            this.toolStripDropDownButtonFile.Size = new System.Drawing.Size(66, 24);
            this.toolStripDropDownButtonFile.Text = "File";
            // 
            // toolStripMenuItemEncode
            // 
            this.toolStripMenuItemEncode.Name = "toolStripMenuItemEncode";
            this.toolStripMenuItemEncode.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItemEncode.Text = "Encode";
            // 
            // toolStripMenuItemDecode
            // 
            this.toolStripMenuItemDecode.Name = "toolStripMenuItemDecode";
            this.toolStripMenuItemDecode.Size = new System.Drawing.Size(144, 26);
            this.toolStripMenuItemDecode.Text = "Decode";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 503);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buttonDecode);
            this.Controls.Add(this.buttonEncode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base64 Coder";
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonDecode;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemEncode;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDecode;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

