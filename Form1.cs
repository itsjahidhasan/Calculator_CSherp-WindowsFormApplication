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
    public partial class Calculator : Form
    {
        Double result = 0;
        String operation = "";
        bool operationCheck = false;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if((richTextBox1.Text == "0") || (operationCheck))
            {
                richTextBox1.Clear();
            }

            operationCheck = false;
            Button button = (Button)sender;

            if (button.Text==".")
            {
                if(!richTextBox1.Text.Contains("."))
                    {
                    richTextBox1.Text = richTextBox1.Text + button.Text;
                }

            }else
            richTextBox1.Text = richTextBox1.Text + button.Text;
            
        }

        private void Operation_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = Double.Parse(richTextBox1.Text);
            label2.Text = result + " " + operation;
            operationCheck = true;
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "0";
            result = 0;
            label2.Text = "";


        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+":
                    label2.Text = label2.Text + richTextBox1.Text;
                    richTextBox1.Text = (result + Double.Parse(richTextBox1.Text)).ToString();
                    
                    break;
                case "-":
                    label2.Text = label2.Text + richTextBox1.Text;
                    richTextBox1.Text = (result - Double.Parse(richTextBox1.Text)).ToString();
                    break;
                case "X":
                    label2.Text = label2.Text + richTextBox1.Text;
                    richTextBox1.Text = (result * Double.Parse(richTextBox1.Text)).ToString();
                    break;
                case "/":
                    label2.Text = label2.Text + richTextBox1.Text;
                    richTextBox1.Text = (result / Double.Parse(richTextBox1.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}
