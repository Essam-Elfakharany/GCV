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

namespace WindowsMultiForms
{
    public partial class frmMax : Form
    {
        public frmMax()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string displayNbrs = "";
            Random random = new Random();
            int randomNumber = 0;

            for (int i = 0; i < 8; i++)
            {
               randomNumber = random.Next(1, 10);
               displayNbrs += " " + randomNumber.ToString() + "\n";
            }
            textBox1.Text = displayNbrs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dir = @"C:\Test3\";
            if (!Directory.Exists(dir)){
                MessageBox.Show(@"C:\Test3\ doesn't exist!");
                Directory.CreateDirectory(dir);
            }
            else {
                MessageBox.Show("C:\\Test3\\ exist!");
            }
            string path = dir + "Names.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
                MessageBox.Show(path + " deleted!");
            }
            else {
                MessageBox.Show(path + " doesn't exist!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dirPath = @"C:\Test\"; // .\Test
            string filePath = @"C:\Test\Names.txt"; // .\Test\Names.txt
            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                // code that uses the file stream to read and write data file
                MessageBox.Show("Find it and Open it!");
                // create the output stream for a text file that exists
                StreamWriter textOut = new StreamWriter(fs);
                // write the fields into text file
                textOut.Write("Hello ");
                textOut.WriteLine("World!!!");
                // close the output stream for the text file
                textOut.Close();

            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(dirPath + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }
        }
    }
}
