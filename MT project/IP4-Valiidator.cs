using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_project
{
    public partial class IP4_Valiidator : Form
    {
        public IP4_Valiidator()
        {
            InitializeComponent();
        }
        static string dirPath = @".\Files\";
        static string filePath = dirPath + "IP4.dat";

        private void button2_Click(object sender, EventArgs e)
        {
            txtIP.Clear();//rest//method
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to quit the App? ",
            "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }

        private void IP4_Valiidator_Load(object sender, EventArgs e)
        {
            lblDate.Text +=  DateTime.Today.ToLongDateString();
            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);
        }

        private void btnValidateIP_Click(object sender, EventArgs e)
        {
            string IP4 = txtIP.Text.ToString().Trim();

            string IP = @"^([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$";
            Regex check = new Regex(IP);
            if (string.IsNullOrEmpty(IP4))
            {
                MessageBox.Show(IP4 + "Please enter IP");
            }
            else if (check.IsMatch(IP4, 0))
            {
            
                MessageBox.Show(IP4 + "IP is Valid");
                Binary();
            }
            else if (!check.IsMatch(IP, 0))
            {
                MessageBox.Show(IP4 + "\nThe IP must have 4 bytes" + "\ninteger number between 0 to 255" + "\nseparated by a dot(255.255.255.255)", "Error");
            }
            else
            {
                MessageBox.Show(IP4 + "IP is not Valid");
            }
        }
        private void Binary()
        {
            FileStream fs = null;
            try
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write);
                if (txtIP.Text != "")
                {
                    BinaryWriter binaryOut = new BinaryWriter(fs);
                    binaryOut.Write(txtIP.Text);
                    binaryOut.Write(DateTime.Now.ToString());
                    binaryOut.Close();
                }
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

        private void txtIP_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
