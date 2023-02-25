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
    public partial class MoneyEX : Form
    {
        public MoneyEX()
        {
            InitializeComponent();
        }
        string fromName = "";
        string toName = ""; // holding the name of the currency
        double fromCurrency = 0;
        double toCurrency = 0;
        static string dirPath = @".\Files\";
        static string filePath = dirPath + "moneyEX.txt";


        private void MoneyEX_Load(object sender, EventArgs e)
        {
            
                if (!Directory.Exists(dirPath))
                    Directory.CreateDirectory(dirPath);
    
        }


        private void btnConvert_Click(object sender, EventArgs e)
        {
            Checkbtn();// call the function
            if (txtFrom.Text == null || txtFrom.Text.Trim() == "")
            {
                MessageBox.Show("please Enter a valid amount");
            }
            // MessageBox.Show(fromCurrency + "\t" + toCurrency);
            try
            {
            double amount = Convert.ToDouble(txtFrom.Text.Trim());// 
            txtto.Text = (fromCurrency * amount / toCurrency).ToString("0.00");// 2 decemel points
                FileStream fs = null;

                try
                {

                    fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                    StreamWriter textOut = new StreamWriter(fs);
                    string textTofile = txtFrom.Text + " " + " = " + txtto.Text + " " + "\t" + DateTime.Now ;
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

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtFrom.Clear();
                txtFrom.Focus();
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
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
                MessageBox.Show(textToDisplay, "MoneyEX- Essam");
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
        private void Checkbtn()// function to check RB
        {
            double CAD = 1;
            double USD = 1.28807;
            double EUR = 1.30486;
            double GBP = 1.54959;
            double EGP = 0.0679411;//Egyption pound
            if (rbcadf.Checked)
            {
                fromName = rbcadf.Text;
                fromCurrency = CAD; 
            }
            else if (rbusdf.Checked)
            {
                fromName = rbusdf.Text;
                fromCurrency = USD;
            }
            else if (rbeurf.Checked)
                {
                    fromName = rbeurf.Text;
                    fromCurrency = EUR;
            }
            else if (rbgbpf.Checked)
            {
                fromName = rbgbpf.Text;
                fromCurrency = GBP;
            }
            else if (rbegpf.Checked)
            {
                fromName = rbegpf.Text;
                fromCurrency = EGP;
            }

            if (rbcadt.Checked)
            {
                toName = rbcadt.Text;
                toCurrency = CAD;
            }
            else if (rbusdt.Checked)
            {
                toName = rbusdt.Text;
                toCurrency = USD;
            }
            else if (rbeurt.Checked)
            {
                toName = rbeurt.Text;
                toCurrency = EUR;
            }
            else if (rbgbpt.Checked)
            {
                toName = rbgbpt.Text;
                toCurrency = GBP;
            }
            else if (rbegpt.Checked)
            {
                toName = rbegpt.Text;
                toCurrency = EGP;
            }
        }

    }
}
