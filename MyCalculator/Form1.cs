using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            Calculate(sender);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            Calculate(sender);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Calculate(sender);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Calculate(sender);
        }

        void Calculate(object sender)
        {
            try
            {
                double firstArgument = double.Parse(FirstArgumentTextBox.Text);
                double secondArgument = double.Parse(SecondArgumentTextBox.Text);
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstArgument, secondArgument);
                ResultTextBox.Text = result.ToString();

            }
            catch
            {
                FirstArgumentTextBox.Text = "";
                SecondArgumentTextBox.Text = "";
            }
        }
    }
}
