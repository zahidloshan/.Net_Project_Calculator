using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double number;
        private string operation;
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text !=null)
            {
                txtBox.Text = "1";

            }

            else
            {
                txtBox.Text = txtBox.Text + "1";
            }
        }


        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "2";

            }

            else
            {
                txtBox.Text = txtBox.Text + "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "3";

            }

            else
            {
                txtBox.Text = txtBox.Text + "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "4";

            }

            else
            {
                txtBox.Text = txtBox.Text + "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "5";

            }

            else
            {
                txtBox.Text = txtBox.Text + "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "6";

            }

            else
            {
                txtBox.Text = txtBox.Text + "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "7";

            }

            else
            {
                txtBox.Text = txtBox.Text + "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "8";

            }

            else
            {
                txtBox.Text = txtBox.Text + "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = "9";

            }

            else
            {
                txtBox.Text = txtBox.Text + "9";
            }
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtBox.Text = txtBox.Text + "0";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBox.Text = "0";
            lblPercentage.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "+";
            
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;
            secondNumber = Convert.ToDouble(txtBox.Text);

            if (operation == "+")
            {
                result=(number+secondNumber);
                txtBox.Text = Convert.ToString(result);
                number = result;
            }

            if (operation == "-")
            {
                result = (number - secondNumber);
                txtBox.Text = Convert.ToString(result);
                number = result;
            }
            if (operation == "*")
            {
                result = (number * secondNumber);
                txtBox.Text = Convert.ToString(result);
                number = result;
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    txtBox.Text = "Cannot divided by 0";
                }
                else 
                {
                    result = (number / secondNumber);
                    txtBox.Text = Convert.ToString(result);
                    number = result;
                }
                
            }
            
           
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "-";
          
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "*";

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            number = Convert.ToDouble(txtBox.Text);
            txtBox.Text = "0";
            operation = "/";

        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (txtBox.Text == "0" && txtBox.Text != null)
            {
                txtBox.Text = ".";

            }

            else
            {
                txtBox.Text = txtBox.Text + ".";
            }

        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
           
            double n = Convert.ToDouble(txtBox.Text);
            lblPercentage.Text = n.ToString() + "%";
            number = n/100;
            txtBox.Text = Convert.ToString(number);
           
        }

        

        

    }
}
