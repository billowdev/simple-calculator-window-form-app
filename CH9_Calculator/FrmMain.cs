using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH9_Calculator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        string n1 = "";
        string n2 = "";
        string opr = "";
        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtNum.Clear();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "0";
            }
            else
            {
                txtNum.Text += "0";
                n2 = txtNum.Text;
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "1";
            }
            else
            {
                txtNum.Text += "1";
                n2 = txtNum.Text;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "2";
            }
            else
            {
                txtNum.Text += "2";
                n2 = txtNum.Text;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "3";
            }
            else
            {
                txtNum.Text += "3";
                n2 = txtNum.Text;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "4";
            }
            else
            {
                txtNum.Text += "4";
                n2 = txtNum.Text;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "5";
            }
            else
            {
                txtNum.Text += "5";
                n2 = txtNum.Text;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "6";
            }
            else
            {
                txtNum.Text += "6";
                n2 = txtNum.Text;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "7";
            }
            else
            {
                txtNum.Text += "7";
                n2 = txtNum.Text;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "8";
            }
            else
            {
                txtNum.Text += "8";
                n2 = txtNum.Text;

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += "9";
            }
            else
            {
                txtNum.Text += "9";
                n2 = txtNum.Text;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                opr = "+";
                n1 = txtNum.Text;
                txtRawNum.Text = n1 + opr;
                txtNum.Text = "";
                txtNum.Focus();
            }
            else
            {
                txtRawNum.Text = n1 + opr + txtNum.Text;
                txtNum.Text = "";
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                opr = "-";
                n1 = txtNum.Text;
                txtRawNum.Text = n1 + opr;
                txtNum.Text = "";
                txtNum.Focus();
            }
            else
            {
                txtRawNum.Text = n1 + opr + txtNum.Text;
                txtNum.Text = "";

            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                opr = "*";
                n1 = txtNum.Text;
                txtRawNum.Text = n1 + opr;
                txtNum.Text = "";
                txtNum.Focus();
            }
            else
            {
                txtRawNum.Text = n1 + opr + txtNum.Text;
                txtNum.Text = "";

            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                opr = "/";
                n1 = txtNum.Text;
                txtRawNum.Text = n1 + opr;
                txtNum.Text = "";
                txtNum.Focus();
            }
            else
            {
                txtRawNum.Text = n1 + opr + txtNum.Text;
                txtNum.Text = "";

            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {

            Int32 num1 = Convert.ToInt32(n1);
            Int32 num2 = Convert.ToInt32(txtNum.Text);
            try
            {
                if (opr == "+")
                {
                    txtNum.Text = Convert.ToString(Add(num1, num2));
                    txtRawNum.Text = "";
                }
                if (opr == "-")
                {
                    txtNum.Text = Convert.ToString(Sub(num1, num2));
                    txtRawNum.Text = "";
                }
                if (opr == "*")
                {
                    txtNum.Text = Convert.ToString(Mul(num1, num2));
                }
                if (opr == "/")
                {
                    txtNum.Text = Convert.ToString(Div(num1, num2));
                }
                if (opr == "pow")
                {
                    txtNum.Text = Convert.ToString(Math.Pow(num1, num2));
                }
            }
            catch (FormatException)
            {
                txtNum.Text = "Error";
            }
        }

        public double Add(Int32 op1, Int32 op2)
        {
            double sum = Convert.ToDouble(op1 + op2);
            n1 = "";
            n2 = "";
            opr = "";
            return sum;
        }
        public double Sub(Int32 op1, Int32 op2)
        {
            double res = Convert.ToDouble(op1 - op2);
            n1 = "";
            n2 = "";
            opr = "";
            return res;
        }

        public double Mul(Int32 op1, Int32 op2)
        {
            double res = Convert.ToDouble(op1 * op2);
            n1 = "";
            n2 = "";
            opr = "";
            return res;

        }

        public double Div(Int32 op1, Int32 op2)
        {
            double res = Convert.ToDouble(op1 / op2);
            n1 = "";
            n2 = "";
            opr = "";
            return res;
        }

        // power button
        private void btnPow_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                opr = "pow";
                n1 = txtNum.Text;
                txtRawNum.Text = n1 + opr;
                txtNum.Text = "";
                txtNum.Focus();
            }
            else
            {
                txtRawNum.Text = n1 + opr + txtNum.Text;
                txtNum.Text = "";

            }
        }
        // Clear Function
        private void btnC_Click(object sender, EventArgs e)
        {
            txtRawNum.Text = "";
            txtNum.Text = "";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
        }

    }
}
