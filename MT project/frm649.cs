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

namespace MT_project
{
    public partial class frm649 : Form
    {
        static string dirPath = @".\Files\";
        static string filePath = dirPath + "frm649.txt";
        public frm649()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the App? ",
            "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string displayNbrs = "";
            Random random = new Random();
            int randomNumber = 0;

            for (int i = 0; i < 8; i++)
            {
                randomNumber = random.Next(1, 50); //random.Next(1, 50); for MAX
                displayNbrs += randomNumber.ToString() + " ";
            }
            textBox1.Text = displayNbrs;
            FileStream fs = null;

            try
            {

                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                string textTofile = textBox1.Text + " " + "\t" + DateTime.Now + " ";
                textOut.WriteLine(textTofile);// write in new line
                textOut.Close();

                // code that uses the file stream to read and write data file
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "File Not Found");
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show(filePath + " not found.", "Directory Not Found");
            }
            catch (IOException ex)
            { MessageBox.Show(ex.Message, "IOException"); }
            finally { if (fs != null) fs.Close(); }

        }

        private void frm649_Load(object sender, EventArgs e)
        {
            {

                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                FileStream fs = null;
                try
                {
                    fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    StreamReader textIn = new StreamReader(fs);
                    string textToDisplay = "";
                    while (textIn.Peek() != -1)
                    {
                        textToDisplay += textIn.ReadLine() + "\n";
                    }
                    MessageBox.Show(textToDisplay, "frm649- Essam");
                    textIn.Close();
                }
                catch (IOException ex)
                { MessageBox.Show(ex.Message, "IOException"); }
                finally
                {
                    if (fs != null)
                    {
                        fs.Close();
                    }
                }
            }
        }
    }
}
