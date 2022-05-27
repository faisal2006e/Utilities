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

namespace DirectoryRead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo di = new DirectoryInfo(textBox1.Text);
            FileInfo[] files = di.GetFiles("*.sql");
            string str = "";
            foreach (FileInfo file in files)
            {
                richTextBox1.Text += file.Name + Environment.NewLine;
            }
        }
    }
}
