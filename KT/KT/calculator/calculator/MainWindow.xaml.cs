using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace calculator
{
    public partial class MainWindow : Window
    {
        private string currentNumber1 = "";
        private string currentNumber2 = "";
        private string currentResult = "";
        private bool isFirstNumberActive = true;
        private string currentOperation = "";

        public MainWindow()
        {
            InitializeComponent();
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            textBlock1.Text = currentNumber1;
            textBlock2.Text = currentNumber2;
            textBlock3.Text = currentResult;
        }


        private void AddDigit(string digit)
        {
            if (isFirstNumberActive)
            {
                currentNumber1 = currentNumber1 == "0" ? digit : currentNumber1 + digit;
            }
            else
            {
                currentNumber2 = currentNumber2 == "0" ? digit : currentNumber2 + digit;
            }
            UpdateDisplay();
        }

        private void SwitchActiveNumber()
        {
            isFirstNumberActive = !isFirstNumberActive;
        }

        private void btnOne_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("1");
        }

        private void btnTwo_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("2");
        }

        private void btnTree_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("3");
        }

        private void btnFour_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("4");
        }

        private void btnFive_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("5");
        }

        private void btnSix_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("6");
        }

        private void btnSeven_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("7");
        }

        private void btnLight_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("8");
        }

        private void btnWine_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("9");
        }

        private void btnZero_Click(object sender, RoutedEventArgs e)
        {
            AddDigit("0");
        }

        private void btnPink_Click(object sender, RoutedEventArgs e)
        {
            currentOperation = "+";
            if (isFirstNumberActive && currentNumber1 != "0")
            {
                isFirstNumberActive = false;
            }
        }

        private void btnHurst_Click(object sender, RoutedEventArgs e)
        {
            currentOperation = "-";
            if (isFirstNumberActive && currentNumber1 != "0")
            {
                isFirstNumberActive = false;
            }
        }

        private void btnYamoshit_Click(object sender, RoutedEventArgs e)
        {
            currentOperation = "*";
            if (isFirstNumberActive && currentNumber1 != "0")
            {
                isFirstNumberActive = false;
            }
        }

        private void btnDelix_Click(object sender, RoutedEventArgs e)
        {
            currentOperation = "/";
            if (isFirstNumberActive && currentNumber1 != "0")
            {
                isFirstNumberActive = false;
            }
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            CalculateResult();
        }

        private void btnAC_Click(object sender, RoutedEventArgs e)
        {
            currentNumber1 = "0";
            currentNumber2 = "0";
            currentResult = "0";
            currentOperation = "";
            isFirstNumberActive = true;
            UpdateDisplay();
        }

        private void CalculateResult()
        {
            try
            {
                double num1 = double.Parse(currentNumber1);
                double num2 = double.Parse(currentNumber2);
                double result = 0;

                switch (currentOperation)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        if (num2 != 0)
                            result = num1 / num2;
                        else
                            throw new DivideByZeroException();
                        break;
                    default:
                        return;
                }

                currentResult = result.ToString();
                UpdateDisplay();
            }
            catch (Exception ex)
            {
                currentResult = "Error";
                UpdateDisplay();
            }
        }
    }
}
