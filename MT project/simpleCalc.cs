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
    public partial class simpleCalc : Form
    {
        public simpleCalc()
        {
            InitializeComponent();
        }
        CalcLog objcalc = new CalcLog();
        static string dirPath = @".\Files\";
        static string filePath = dirPath + "Calc.txt";

        private void simpleCalc_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }
        private void btnN1_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "1";//Replace 0 with 1 if the screen is 0
            }
            else
            {
                txtbScr.Text += "1";//add the 1 to the screen
            }
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "2";
            }
            else
            {
                txtbScr.Text += "2";
            }
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "3";
            }
            else
            {
                txtbScr.Text += "3";
            }
        }
        private void btnN4_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "4";
            }
            else
            {
                txtbScr.Text += "4";
            }
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "5";
            }
            else
            {
                txtbScr.Text += "5";
            }
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "6";
            }
            else
            {
                txtbScr.Text += "6";
            }
        }

        private void btnN7_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "7";
            }
            else
            {
                txtbScr.Text += "7";
            }
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "8";
            }
            else
            {
                txtbScr.Text += "8";
            }
        }

        private void btnN9_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "9";
            }
            else
            {
                txtbScr.Text += "9";
            }
        }

        private void btnN0_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text == "0")//&& txtbScr.Text != null)
            {
                txtbScr.Text = "0";
            }
            else
            {
                txtbScr.Text += "0";
            }
        }

        private void btnDec_Click(object sender, EventArgs e)
        {
            if (txtbScr.Text.Contains('.'))// if there is Decimel point don't add any
            {
                return;
            }
            else
            {
                txtbScr.Text += ".";
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (objcalc.Op != null)
            {
                return;
            }
            else
            {
                objcalc.Operand1 = Convert.ToDouble(txtbScr.Text);
                objcalc.Op = "+";
                txtbScr.Text = txtbScr.Tag.ToString();//the defult text (0)
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (objcalc.Op != null)
            {
                return;
            }
            else
            {
                objcalc.Operand1 = Convert.ToDouble(txtbScr.Text);
                objcalc.Op = "-";
                txtbScr.Text = txtbScr.Tag.ToString();//the defult text (0)
            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            if (objcalc.Op != null)
            {
                return;
            }
            else
            {
                objcalc.Operand1 = Convert.ToDouble(txtbScr.Text);
                objcalc.Op = "*";
                txtbScr.Text = txtbScr.Tag.ToString();//the defult text (0)
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (objcalc.Op != null)
            {
                return;
            }
            else
            {
                objcalc.Operand1 = Convert.ToDouble(txtbScr.Text);
                objcalc.Op = "/";
                txtbScr.Text = txtbScr.Tag.ToString();//the defult text (0)
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (objcalc.Op != null)
            {
                objcalc.Operand2 = Convert.ToDouble(txtbScr.Text);
                txtbScr.Text = objcalc.Eql().ToString();
                Write();
                objcalc.Op = null;// back to "0" or reset after finish the operation
            }
            else
            {
                return;//go back don't excute.
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtbScr.Text = txtbScr.Tag.ToString();//
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the App? ",
            "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
        private void Write()
        {
            FileStream fs = null;

            try
            {

                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                StreamWriter textOut = new StreamWriter(fs);
                string textTofile = objcalc.Operand1.ToString() + " " + objcalc.Op + " " + objcalc.Operand2.ToString() + " = " + objcalc.CurrentValue.ToString() + " " + DateTime.Now;
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

    }
}
        
    

