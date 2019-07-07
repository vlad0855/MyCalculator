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

        void CalculateOneArgument(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = double.Parse(FirstArgumentTextBox.Text);
                double result = 0;
                IOneArgumentCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                result = calculator.Calculate(firstArgument);
                ResultTextBox.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }


        private void CalculateTwoArguments(object sender, EventArgs e)
        {
            try
            {
                double firstArgument = double.Parse(FirstArgumentTextBox.Text);
                double secondArgument = double.Parse(SecondArgumentTextBox.Text);
                double result = 0;
                ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                result = calculator.Calculate(firstArgument, secondArgument);
                ResultTextBox.Text = result.ToString();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK);
                FirstArgumentTextBox.Text = "";
                SecondArgumentTextBox.Text = "";

            }
        }
    }
}