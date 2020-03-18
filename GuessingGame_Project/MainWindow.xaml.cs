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

namespace GuessingGame_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Lose_Label.Visibility = Visibility.Hidden;
            Win_Label.Visibility = Visibility.Hidden;
            Hint_Label.Visibility = Visibility.Hidden;
        }
        private void Generate_Button_Click(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            int tries = 0;
            int num = rnd.Next(10);
            do
            {
                if(Convert.ToInt32(Input_Text.Text)>num)
                {
                    Hint_Label.Visibility = Visibility.Visible;
                    Hint_Label.Content = "Your number is too high";
                }
                else if (Convert.ToInt32(Input_Text.Text) < num)
                {
                    Hint_Label.Visibility = Visibility.Visible;
                    Hint_Label.Content = "Your number is too low";
                }
                if (Input_Text.Text==num.ToString()&&tries<=3)
                {
                    Win_Label.Visibility = Visibility.Visible;
                    Lose_Label.Visibility = Visibility.Hidden;
                    Hint_Label.Visibility = Visibility.Hidden;
                }
                else if(Input_Text.Text!=num.ToString()&&tries>3)
                {
                    Lose_Label.Visibility = Visibility.Visible;
                    Win_Label.Visibility = Visibility.Hidden;
                    Hint_Label.Visibility = Visibility.Hidden;
                }

            } while (tries!=3);
            GeneratedNumber_Label.Content = num.ToString();

        }
    }
}
