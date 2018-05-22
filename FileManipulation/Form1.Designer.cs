namespace FileManipulation
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdRead = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cmdWrite = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdRead
            // 
            this.cmdRead.Location = new System.Drawing.Point(38, 83);
            this.cmdRead.Name = "cmdRead";
            this.cmdRead.Size = new System.Drawing.Size(75, 23);
            this.cmdRead.TabIndex = 0;
            this.cmdRead.Text = "Read";
            this.cmdRead.UseVisualStyleBackColor = true;
            this.cmdRead.Click += new System.EventHandler(this.cmdRead_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 134);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 77);
            this.textBox1.TabIndex = 1;
            // 
            // cmdWrite
            // 
            this.cmdWrite.Location = new System.Drawing.Point(119, 83);
            this.cmdWrite.Name = "cmdWrite";
            this.cmdWrite.Size = new System.Drawing.Size(75, 23);
            this.cmdWrite.TabIndex = 2;
            this.cmdWrite.Text = "Write";
            this.cmdWrite.UseVisualStyleBackColor = true;
            this.cmdWrite.Click += new System.EventHandler(this.cmdWrite_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.cmdWrite);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmdRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdRead;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button cmdWrite;
    }
}

