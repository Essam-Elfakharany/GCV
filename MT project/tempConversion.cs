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
//using System.Globalization;
//using System.Threading;

namespace MT_project
{
    public partial class tempConversion : Form
    {
        public tempConversion()
        {
            InitializeComponent();
        }
        double celsius;
        double fahrenhit;
        static string dirPath = @".\Files\";
        static string filePath = dirPath + "temp.txt";

        private void tempConversion_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtMessage.Clear();
           if (txtFromTemp.Text== null || txtFromTemp.Text.Trim()=="")
            {
                MessageBox.Show("please Enter a valid temperature");
            }
            try
            {
                if (rbCtoF.Checked)
                {
                    celsius = Convert.ToInt32(txtFromTemp.Text);
                    fahrenhit = ((celsius * 1.8) + 32);
                    txtToTemp.Text = fahrenhit.ToString("0.##");
                    Messages();
                }
                else 
                {
                    fahrenhit = Convert.ToInt32(txtFromTemp.Text);
                    celsius = ((fahrenhit - 32) * 5 / 9);
                    txtToTemp.Text = celsius.ToString("0.##");
                    Messages();
                }
                FileStream fs = null;

                try
                {

                    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    string textTofile = txtFromTemp.Text + " " + lblFromTemp.Text + " = " + txtToTemp.Text + " " + lblToTemp.Text + "\t" + DateTime.Now + " " + txtMessage.Text;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//Ex
                txtFromTemp.Clear();//delete the txtbox
                txtFromTemp.Focus();//back to the clear txt
            }
           
           
        }

       
        private void button2_Click(object sender, EventArgs e)
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
                MessageBox.Show(textToDisplay, "tempconversion- Essam");
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the App? ",
                 "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void rbCtoF_CheckedChanged(object sender, EventArgs e)
        {
            // switch C to F and reverse with radoibuttons check
            if (rbCtoF.Checked)
            {
                lblFromTemp.Text = "C";
                lblToTemp.Text = "F";
            }
            else
            {
                lblFromTemp.Text = "F";
                lblToTemp.Text = "C";
            }
        }
    
        private void Messages()//method for messages
        {
            //Messages
            if (celsius == 100 )
            {
                txtMessage.Text = " Water boils";
            }
         
            else if (celsius == 40)
            {
                txtMessage.Text = " Hot bath";
            }
           
            else if ( celsius==37)
            {
                txtMessage.Text = " Body temperature";
            }
            else if (celsius == 30)
            {
                txtMessage.Text = "Beach weather";
            }
            else if (celsius >= 21&& celsius<22)
            {
                txtMessage.Text = "Room temperutre";
            }
            
            else if (celsius ==10)
            {
                txtMessage.Text = " Cool Day";
            }
            else if (celsius == 0)
            {
                txtMessage.Text = " Freezing point";
            }
            else if (celsius >=-18 && celsius<-17)
            {
                txtMessage.Text = " Very Cold Day";
            }
            else if (celsius == -40)
            {
                txtMessage.Text = "Extremely cold Day";
            }



             if (celsius >= 40)
            {
                txtFromTemp.ForeColor = Color.Red;
                txtToTemp.ForeColor = Color.Red;
            }
            else if (celsius < 40 && celsius >= 37)
            {
                txtFromTemp.ForeColor = Color.Orange;
                txtToTemp.ForeColor = Color.Orange;
            }
            else if (celsius < 37 && celsius > 21)
            {
                txtFromTemp.ForeColor = Color.Green;
                txtToTemp.ForeColor = Color.Green;
            }
            else if (celsius <= 10)
            {
                txtFromTemp.ForeColor = Color.Blue;
                txtToTemp.ForeColor = Color.Blue;
            }

        }
    }
}
