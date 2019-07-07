using System;
using System.Windows.Forms;
using MyCalculator.OneArgument;
using MyCalculator.TwoArguments;

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
            CalculateTwoArguments(sender);
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            CalculateTwoArguments(sender);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            CalculateTwoArguments(sender);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            CalculateTwoArguments(sender);
        }
        private void Squaring_Click(object sender, EventArgs e)
        {
            CalculateOneArgument(sender);
        }
        private void SQRT_Click(object sender, EventArgs e)
        {
            CalculateOneArgument(sender);
        }

        void CalculateTwoArguments(object sender)
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
        void CalculateOneArgument(object sender)
        {
            try
            {
                double firstArgument = double.Parse(FirstArgumentTextBox.Text);
                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double result = calculator.Calculate(firstArgument);
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
