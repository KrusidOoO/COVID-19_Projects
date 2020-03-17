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

namespace Calculator_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //
        double FirstNumber = 0;
        double newFirst;
        double secondNumber;
        double result = 0;
        string[] setMathChoice = new string[] {"+","-","*","/" };
        public MainWindow()
        {
            InitializeComponent();

        }

        #region Numbers
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            //1 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "1";
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            //2 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "2";
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            //3 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "3";
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            //4 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "4";
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            //5 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "5";
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            //6 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "6";
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            //7 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "7";
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            //8 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "8";
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            //9 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "9";
        }

        private void Button0_Click(object sender, RoutedEventArgs e)
        {
            //0 inputs x in the textbox
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "0";
            if (textBox2.Text == "0")
            {
                textBox2.Text = "";
            }
            textBox2.Text += "0";
        }
        #endregion

        #region Extra "Features"
        private void ButtonDEL_Click(object sender, RoutedEventArgs e)
        {
            //Delete - Deletes the whole "historic" of numbers
            textBox1.Text = "";
            textBox2.Text = "";
        }
        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            //clear 1 character of current input
            if (textBox1.Text.Length > 1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            if (textBox2.Text.Length > 1)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
        }

        private void ButtonOFF_Click(object sender, RoutedEventArgs e)
        {
            //Off button - quits the application
            Application.Current.Shutdown();
        }

        #endregion
        
        #region Maff
        private void ButtonPlus_Click(object sender, RoutedEventArgs e)
        {
            //plus - adds two numbers together
            if (newFirst > 0)
            {
                result = result + FirstNumber;
            }
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice.ElementAt(0);
            textBox2.Text += "+";
        }

        private void ButtonMinus_Click(object sender, RoutedEventArgs e)
        {
            //Minus - subtacts two numbers from eachother
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice.ElementAt(1);
            if (textBox1.Text == "")
            {
                textBox1.Text += "-";
            }
            textBox2.Text += "-";
        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            //Multiply - multiplies two numbers
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice.ElementAt(2);
            textBox2.Text += "*";
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            //Division - divides two numbers
            if (secondNumber == 0)
            {
                textBox1.Text = "Cannot divide by zero";
            }
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice.ElementAt(3);
            textBox2.Text += "/";
        }

        private void ButtonEquals_Click(object sender, RoutedEventArgs e)
        {
            //Equals - gives the result of given input
            secondNumber = Convert.ToDouble(textBox1.Text);
            if (setMathChoice.ElementAt(0) == "+")
            {
                result = FirstNumber + secondNumber;
                newFirst = result;
                textBox1.Text = result.ToString();
            }
            else if (setMathChoice.ElementAt(1) == "-")
            {
                result = FirstNumber - secondNumber;
                textBox1.Text = result.ToString();
            }
            else if (setMathChoice.ElementAt(2) == "*")
            {
                result = FirstNumber * secondNumber;
                textBox1.Text = result.ToString();
            }
            else if (setMathChoice.ElementAt(3) == "/")
            {
                result = FirstNumber / secondNumber;
                textBox1.Text = result.ToString();
            }
        }
        #endregion 

    }
}