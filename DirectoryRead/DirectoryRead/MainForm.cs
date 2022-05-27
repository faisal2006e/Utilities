using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DirectoryRead
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDirectoryRead_Click(object sender, EventArgs e)
        {
            Form1 l_DirectoryRead = new Form1();
            l_DirectoryRead.ShowDialog();
        }

        private void btnFileSplit_Click(object sender, EventArgs e)
        {
            frmFileRead l_FileRead = new frmFileRead();
            l_FileRead.ShowDialog();
        }
    }
}
