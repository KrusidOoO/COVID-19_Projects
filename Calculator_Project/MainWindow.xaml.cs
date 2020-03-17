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
        double secondNumber;
        double result = 0;
        string setMathChoice = "";
        public MainWindow()
        {
            InitializeComponent();

        }

        #region number inputs
        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            //1 inputs x in the textbox
            if(textBox1.Text=="0")
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

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
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

        private void button_Copy_Click(object sender, RoutedEventArgs e)
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

        private void button_Click(object sender, RoutedEventArgs e)
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

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
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
        private void button_Copy5_Click(object sender, RoutedEventArgs e)
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

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
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

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
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

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
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

        private void button_Copy8_Click(object sender, RoutedEventArgs e)
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

        #region Extra functions
        private void button_Copy15_Click(object sender, RoutedEventArgs e)
        {
            //Delete - Deletes the whole "historic" of numbers
            textBox1.Text = "";
        }

        private void button_Copy16_Click(object sender, RoutedEventArgs e)
        {
            //clear 1 character of current input
            if(textBox1.Text.Length>1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
            if (textBox2.Text.Length > 1)
            {
                textBox2.Text = textBox2.Text.Substring(0, textBox2.Text.Length - 1);
            }
        }

        private void button_Copy14_Click(object sender, RoutedEventArgs e)
        {
            //Off button - quits the application
            Application.Current.Shutdown();
        }
        #endregion
        
        #region Mathematical Functions
        private void button_Copy11_Click(object sender, RoutedEventArgs e)
        {
            //plus - adds two numbers together
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "+";
            textBox2.Text += "+";
        }

        private void button_Copy10_Click(object sender, RoutedEventArgs e)
        {
            //Minus - subtacts two numbers from eachother
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "-";
            if(textBox1.Text=="")
            {
                textBox1.Text += "-";
            }
            textBox2.Text += "-";
        }

        private void button_Copy9_Click(object sender, RoutedEventArgs e)
        {
            //Multiply - multiplies two numbers
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "*";
            textBox2.Text += "*";
        }

        private void button_Copy13_Click(object sender, RoutedEventArgs e)
        {
            //Division - divides two numbers
            if(secondNumber==0)
            {
                textBox1.Text="Cannot divide by zero";
            }
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "/";
            textBox2.Text += "/";
        }

        private void button_Copy12_Click(object sender, RoutedEventArgs e)
        {
            //Equals - gives the result of given input
            secondNumber = Convert.ToDouble(textBox1.Text);
            if(setMathChoice=="+")
            {
                result = FirstNumber + secondNumber;
                textBox1.Text = result.ToString();
            }
            else if(setMathChoice=="-")
            {
                result = FirstNumber - secondNumber;
                textBox1.Text = result.ToString();
            }
            else if(setMathChoice=="*")
            {
                result = FirstNumber * secondNumber;
                textBox1.Text = result.ToString();
            }
            else if(setMathChoice=="/")
            {
                result = FirstNumber / secondNumber;
                textBox1.Text = result.ToString();
            }
        }
        #endregion
    }
}
    