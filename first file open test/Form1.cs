using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace first_file_open_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(@"H:\test.txt"))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    richTextBox1.AppendText(line + "\n");
                }
            }
        }
    }
}
