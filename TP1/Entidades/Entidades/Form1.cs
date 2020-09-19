using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public partial class Form1 : Form
    {
        private double one;
        private double two;
        private string theOperator;

        public Form1()
        {
            InitializeComponent();
        }

        Clases.ClassSum objSum = new Clases.ClassSum();
        Clases.ClassSubtract objSub = new Clases.ClassSubtract();
        Clases.ClassMultiply objMul = new Clases.ClassMultiply();
        Clases.ClassDivide objDiv = new Clases.ClassDivide();
        Clases.ClassConvert objConvert = new Clases.ClassConvert();


        private void btn_0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void btn_Point_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            this.theOperator = "+";
            this.one = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btn_Subtract_Click(object sender, EventArgs e)
        {
            this.theOperator = "-";
            this.one = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btn_Multiply_Click(object sender, EventArgs e)
        {
            this.theOperator = "*";
            this.one = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {
            this.theOperator = "/";
            this.one = double.Parse(textBox.Text);
            textBox.Clear();
        }

        private void btn_Equal_Click(object sender, EventArgs e)
        {
            this.two = double.Parse(textBox.Text);

            double outcome;

            switch(this.theOperator)
            {
                case "+":
                    outcome = objSum.Sum(this.one, this.two);
                    textBox.Text = outcome.ToString();
                    break;

                case "-":
                    outcome = objSub.Subtract(this.one, this.two);
                    textBox.Text = outcome.ToString();
                    break;

                case "*":
                    outcome = objMul.Multiply (this.one, this.two);
                    textBox.Text = outcome.ToString();
                    break;

                case "/":
                    outcome = objDiv.Divide(this.one, this.two);
                    textBox.Text = outcome.ToString();
                    break;
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            textBox.Clear();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length == 1)
                textBox.Text = "";
            else
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
        }

        private void btn_Convert_Click(object sender, EventArgs e)
        {
            textBox.Text = objConvert.Binary(textBox.Text);
        }
    }
}
