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
        public MainWindow()
        {
            InitializeComponent();

        }
        private void Button_click_1(object sender, RoutedEventArgs e)
        {
            Button b = (Button)sender;
            textBox1.Text += b.Content.ToString();
        }
        private void Result_click(object sender, RoutedEventArgs e)
        {
            try
            {
                Result();
            }
            catch (Exception exc)
            {
                textBox1.Text = "Error!";
            }
        }
        private void Result()
        {
            string op;
            int iOp = 0;
            if(textBox1.Text.Contains("+"))
            {
                iOp = textBox1.Text.IndexOf("+");
            }
            else if(textBox1.Text.Contains("-"))
            {
                iOp = textBox1.Text.IndexOf("-");
            }
            else if(textBox1.Text.Contains("*"))
            {
                iOp = textBox1.Text.IndexOf("*");
            }
            else if(textBox1.Text.Contains("/"))
            {
                iOp = textBox1.Text.IndexOf("/");
            }
            else
            {
                //error
            }
            op = textBox1.Text.Substring(iOp, 1);
            double op1 = Convert.ToDouble(textBox1.Text.Substring(0, iOp));
            double op2 = Convert.ToDouble(textBox1.Text.Substring(iOp + 1, textBox1.Text.Length-iOp-1));
            if(op=="+")
            {
                textBox1.Text += "=" + (op1 + op2);
            }
            else if(op=="-")
            {
                textBox1.Text += "=" + (op1 - op2);
            }
            else if(op=="*")
            {
                textBox1.Text += "=" + (op1 * op2);
            }
            else
            {
                textBox1.Text += "=" + (op1 / op2);
            }
        }
        private void Off_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void Del_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "";
        }
        private void R_Click(object sender, RoutedEventArgs e)
        {
            if(textBox1.Text.Length>0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}
    