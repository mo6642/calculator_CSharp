using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DataTable eval = new DataTable();
        public string answer = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            expresion.Text += 2;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            expresion.Text += 0;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            expresion.Text = "";
            result.Text = "";
        }

        private void one_Click(object sender, EventArgs e)
        {
            expresion.Text += 1;
        }

        private void three_Click(object sender, EventArgs e)
        {
            expresion.Text += 3;
        }

        private void dot_Click(object sender, EventArgs e)
        {
            expresion.Text += ".";
        }

        private void four_Click(object sender, EventArgs e)
        {
            expresion.Text += 4;
        }

        private void five_Click(object sender, EventArgs e)
        {
            expresion.Text += 5;
        }

        private void six_Click(object sender, EventArgs e)
        {
            expresion.Text += 6;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            expresion.Text += 7;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            expresion.Text += 8;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            expresion.Text += 9;
        }

        private void sum_Click(object sender, EventArgs e)
        {
            expresion.Text += "+";
        }

        private void sub_Click(object sender, EventArgs e)
        {
            expresion.Text += "-";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            expresion.Text += "*";
        }

        private void devision_Click(object sender, EventArgs e)
        {
            expresion.Text += "/";
        }

        private void mod_Click(object sender, EventArgs e)
        {
            expresion.Text += "%";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            
            
            
            
            try
            {
                // mathimatical exprisions evaluation in c#
                var v = eval.Compute(expresion.Text, "");
                // handling zero devision error
                if (Convert.ToDouble(v) == double.PositiveInfinity || Convert.ToDouble(v) == double.NegativeInfinity)
                {
                    result.Text = "can't devide by zero";
                }
                else
                {

                    result.Text = Convert.ToString(v);
                    answer = result.Text;
                }
            }
            catch
            {
                result.Text = "invalid exprission";
            }
        }

        private void Lbracket_Click(object sender, EventArgs e)
        {
            expresion.Text += "(";
        }

        private void Rbracket_Click(object sender, EventArgs e)
        {
            expresion.Text += ")";
        }

        private void back_Click(object sender, EventArgs e)
        {
            // i used this if to handle the error of substring that accure when string is empty
            if (expresion.Text.Length != 0)
            {
                expresion.Text = expresion.Text.Substring(0, expresion.Text.Length - 1);
            }
        }

        private void preAns_Click(object sender, EventArgs e)
        {
            expresion.Text = answer;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                zero.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                one.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                two.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                three.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                four.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D6)
            {
                five.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                six.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                seven.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                eight.PerformClick();
            }
            else if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                nine.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                sum.PerformClick();
            }
            else if (e.KeyCode == Keys.Divide)
            {
                devision.PerformClick();
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                multiply.PerformClick();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                sub.PerformClick();
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                dot.PerformClick();
            }
            else if (e.KeyCode == Keys.Back)
            {
                back.PerformClick();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                clear.PerformClick();
            }
            
        }
    }
}
