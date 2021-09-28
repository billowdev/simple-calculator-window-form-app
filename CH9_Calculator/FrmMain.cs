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
        private int lastCharacterPosition;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtNum.Clear();

            btn1Divx.Enabled = false;
            btnRoot.Enabled = false;
            btnPow.Enabled = false;
            btnMod.Enabled = false;
            btnSign.Enabled = false;
            // Set property Cursor to Hand
            btn0.Cursor = Cursors.Hand;
            btn1.Cursor = Cursors.Hand;
            btn2.Cursor = Cursors.Hand;
            btn3.Cursor = Cursors.Hand;
            btn4.Cursor = Cursors.Hand;
            btn5.Cursor = Cursors.Hand;
            btn6.Cursor = Cursors.Hand;
            btn7.Cursor = Cursors.Hand;
            btn8.Cursor = Cursors.Hand;
            btn9.Cursor = Cursors.Hand;
            btnAdd.Cursor = Cursors.Hand;
            btnSub.Cursor = Cursors.Hand;
            btnMul.Cursor = Cursors.Hand;
            btnDivide.Cursor = Cursors.Hand;
            btnEqual.Cursor = Cursors.Hand;
            btnDel.Cursor = Cursors.Hand;
            btnSign.Cursor = Cursors.Hand;
            btnPoint.Cursor = Cursors.Hand;
            btnCE.Cursor = Cursors.Hand;
            btnC.Cursor = Cursors.Hand;
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

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                txtNum.Text += ".";
            }
            else
            {
                txtNum.Text += ".";
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
        private void btnMod_Click(object sender, EventArgs e)
        {
            if (opr == "")
            {
                opr = "%";
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

            Double num1 = Convert.ToDouble(n1);
            Double num2 = Convert.ToDouble(txtNum.Text);
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
                if (opr == "%")
                {
                    txtNum.Text = Convert.ToString((num1 % num2));
                }
            }
            catch (FormatException)
            {
                txtNum.Text = "Error";
            }
        }

        public double Add(Double op1, Double op2)
        {
            double sum = Convert.ToDouble(op1 + op2);
            n1 = "";
            n2 = "";
            opr = "";
            return sum;
        }
        public double Sub(Double op1, Double op2)
        {
            double res = Convert.ToDouble(op1 - op2);
            n1 = "";
            n2 = "";
            opr = "";
            return res;
        }

        public double Mul(Double op1, Double op2)
        {
            double res = Convert.ToDouble(op1 * op2);
            n1 = "";
            n2 = "";
            opr = "";
            return res;

        }

        public double Div(Double op1, Double op2)
        {
            double res = op1 / op2;
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
            txtNum.Text = txtNum.Text.Remove(lastCharacterPosition, 1);

            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Error", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
