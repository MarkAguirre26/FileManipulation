using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileManipulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdRead_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Users\Mark\Desktop\Notes and Concerns for LMS.txt");
            foreach (string s in lines)
            {
                textBox1.Text += s+"\t";
            }
        }
        //

        private void cmdWrite_Click(object sender, EventArgs e)
        {
            string[] lines = { textBox1.Text };

            File.WriteAllLines(@"C:\Users\Mark\Desktop\Notes and Concerns for LMS.txt", lines);
        }
    }
}
