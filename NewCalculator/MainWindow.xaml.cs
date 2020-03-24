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

namespace NewCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long number1 = 0;
        long number2 = 0;
        string operation = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        #region Numbers
        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            //example 50
            //turns into 501
            if (operation == "")
            {
                number1 += 1;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 1;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 2;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 2;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 3;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 3;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 4;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 4;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 5;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 5;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 6;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 6;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 7;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 7;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 8;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 8;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 9;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 9;
                TxtDisplay.Text = number2.ToString();
            }
        }
        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 += 0;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 += 0;
                TxtDisplay.Text = number2.ToString();
            }
        }
        #endregion

        #region Functions
        private void NumPlus_Click(object sender, RoutedEventArgs e)
        {
            operation = "+";
            TxtDisplay.Text = "0";
        }
        private void NumMinus_Click(object sender, RoutedEventArgs e)
        {
            operation = "-";
            TxtDisplay.Text = "0";
        }
        private void NumDivide_Click(object sender, RoutedEventArgs e)
        {
            operation = "/";
            TxtDisplay.Text = "0";
        }
        private void NumMultiply_Click(object sender, RoutedEventArgs e)
        {
            operation = "*";
            TxtDisplay.Text = "0";
        }
        private void NumEquals_Click(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case "+":
                    TxtDisplay.Text = (number1 + number2).ToString();
                    break;
                case "-":
                    TxtDisplay.Text = (number1 - number2).ToString();
                    break;
                case "/":
                    TxtDisplay.Text = (number1 / number2).ToString();
                    break;
                case "*":
                    TxtDisplay.Text = (number1 * number2).ToString();
                    break;
                default:
                    break;
            }
        }
        private void NumPosNeg_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 *=-1;
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 *= -1;
                TxtDisplay.Text = number2.ToString();
            }
        }
        #endregion

        #region Clears
        private void NumCE_Click(object sender, RoutedEventArgs e)
        {
            if(operation=="")
            {
                number1 = 0;
            }
            else
            {
                number2 = 0;
            }
                TxtDisplay.Text = "0";
        }

        private void NumC_Click(object sender, RoutedEventArgs e)
        {
            number1 = 0;
            number2 = 0;
            operation = "";
            TxtDisplay.Text = "0";
        }

        private void NumBackSpace_Click(object sender, RoutedEventArgs e)
        {
            if (operation == "")
            {
                number1 = (number1 / 10);
                TxtDisplay.Text = number1.ToString();
            }
            else
            {
                number2 = (number2 / 10);
                TxtDisplay.Text = number2.ToString();
            }
        }
        #endregion

    }
}
