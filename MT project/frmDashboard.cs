using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_project
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMax objMax = new frmMax();
            objMax.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm649 obj649 = new frm649();
            obj649.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            {
                MoneyEX objEX = new MoneyEX();
                objEX.ShowDialog();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            {
                tempConversion objconversion = new tempConversion();
                objconversion.ShowDialog();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            simpleCalc objsimpleCalc = new simpleCalc();
            objsimpleCalc.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            IP4_Valiidator objIP4 = new IP4_Valiidator();
            objIP4.ShowDialog();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
