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
    public partial class frmFileRead : Form
    {
        public frmFileRead()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            ReadFile(textBox1.Text, Convert.ToInt32(textBox3.Text));
        }

        public void ReadFile(string file, int filePerLines)
        {
            String line;
            int lineNo = 0;
            int fileNo = 1;

            try
            {
                string[] readAllLines = File.ReadAllLines(file);
                List<string> writeLines = new List<string>();
                for (int i= 1; i< readAllLines.Length; i++)
                {
                    writeLines.Add(readAllLines[i]);
                    lineNo++;
                    if (lineNo == filePerLines)
                    {
                        WriteFile(writeLines, textBox2.Text + "\\file" + fileNo + ".sql");
                        writeLines = new List<string>();
                        lineNo = 1;
                        fileNo++;
                    }
                    else if (lineNo < filePerLines && i == readAllLines.Length - 1)
                    {
                        WriteFile(writeLines, textBox2.Text + "\\file" + fileNo + ".sql");
                        writeLines = new List<string>();
                        lineNo = 1;
                        fileNo++;
                    }
                    //Console.WriteLine(s);
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                //Console.WriteLine("Executing finally block.");
            }
        }

        public void WriteFile(List<string> file, string path)
        {
            try
            {
                File.WriteAllLines(path, file);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
    }
}
