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
        double FirstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string setMathChoice = "";
        public MainWindow()
        {
            InitializeComponent();

        }

        #region number inputs
        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            //1
            if(textBox1.Text=="0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "1";
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            //2
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "2";
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            //3
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "3";
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //4
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "4";
        }

        private void button_Copy3_Click(object sender, RoutedEventArgs e)
        {
            //5
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "5";
        }
        private void button_Copy5_Click(object sender, RoutedEventArgs e)
        {
            //6
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "6";
        }

        private void button_Copy7_Click(object sender, RoutedEventArgs e)
        {
            //7
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "7";
        }

        private void button_Copy6_Click(object sender, RoutedEventArgs e)
        {
            //8
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "8";
        }

        private void button_Copy4_Click(object sender, RoutedEventArgs e)
        {
            //9
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "9";
        }

        private void button_Copy8_Click(object sender, RoutedEventArgs e)
        {
            //0
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
            textBox1.Text += "0";
        }
        #endregion

        #region Extra functions
        private void button_Copy15_Click(object sender, RoutedEventArgs e)
        {
            //Delete
            textBox1.Text = "";
        }

        private void button_Copy16_Click(object sender, RoutedEventArgs e)
        {
            //clear current input
            if(textBox1.Text.Length>1)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }

        private void button_Copy14_Click(object sender, RoutedEventArgs e)
        {
            //Off button
            Application.Current.Shutdown();
        }
        #endregion
        
        #region Mathematical Functions
        private void button_Copy11_Click(object sender, RoutedEventArgs e)
        {
            //plus
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "+";
        }

        private void button_Copy10_Click(object sender, RoutedEventArgs e)
        {
            //Minus
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "-";
        }

        private void button_Copy9_Click(object sender, RoutedEventArgs e)
        {
            //Multiply
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "*";
        }

        private void button_Copy13_Click(object sender, RoutedEventArgs e)
        {
            //Division
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            setMathChoice = "/";
        }

        private void button_Copy12_Click(object sender, RoutedEventArgs e)
        {
            //Equals
            secondNumber = Convert.ToDouble(textBox1.Text);
            if(setMathChoice=="+")
            {
                result = FirstNumber + secondNumber;
                textBox1.Text = FirstNumber.ToString() + "+" + secondNumber.ToString() + "=" + result.ToString();
            }
            else if(setMathChoice=="-")
            {
                result = FirstNumber - secondNumber;
                textBox1.Text = FirstNumber.ToString() + "-" + secondNumber.ToString() + "=" + result.ToString();
            }
            else if(setMathChoice=="*")
            {
                result = FirstNumber * secondNumber;
                textBox1.Text = FirstNumber.ToString() + "*" + secondNumber.ToString() + "=" + result.ToString();
            }
            else if(setMathChoice=="/")
            {
                result = FirstNumber / secondNumber;
                textBox1.Text = FirstNumber.ToString() + "/" + secondNumber.ToString() + "=" + result.ToString();
            }
        }
        #endregion
    }
}
    