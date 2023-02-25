using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_project
{
    class CalcLog
    {
        public double CurrentValue; //{ set; get; }//creat objects
        public double Operand1;// { set; get; }
        public double Operand2;// { set; get; }
        public string Op;// { set; get; }//+,/
        private double Add ()//metod
        {
            CurrentValue = Operand1 + Operand2;
            return CurrentValue;
        }
        private double Sub()
        {
            CurrentValue = Operand1 - Operand2;
            return CurrentValue;
        }
        private double Mlt()
        {
            CurrentValue = Operand1 * Operand2;
            return CurrentValue;
        }
        private double Div()
        {
            CurrentValue = Operand1 / Operand2;
            return CurrentValue;
        }
        public double Eql()
        {
            if (Op == "+")
            {
                Add();
            }
            else if (Op == "-")
            {
                Sub();
            }
            else if (Op == "*")
            {
                Mlt();
            }
            else if (Op == "/")
            {
               if(Operand2 == 0)
                {
                    MessageBox.Show("Can't Divide By 0", "Error");
                }
               else
                {
                 Div();
                }
            }
            return CurrentValue;
        }
    }
}
