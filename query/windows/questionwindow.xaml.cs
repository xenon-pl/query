using query.impl;
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
using System.Windows.Shapes;

namespace query
{
    /// <summary>
    /// Interaction logic for questionwindow.xaml
    /// </summary>
    public partial class questionwindow : Window
    {
        public Question question;
        public Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>();
        public questionwindow()
        {
            InitializeComponent();
            Left = 0;
            Top = 0;
            Width = System.Windows.SystemParameters.FullPrimaryScreenWidth;
            Height = System.Windows.SystemParameters.FullPrimaryScreenHeight;
            b();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Answer(0);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Answer(1);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Answer(2);

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Answer(3);
        }
        
        public void Answer(int i)
        {
            if (question.Answers.Values.ToList()[i])
            {
                win();
            }
            else
            {
                lose();

            }
        }

        public async void win()
        {
            b1.Visibility = Visibility.Collapsed;
            b2.Visibility = Visibility.Collapsed;
            b3.Visibility = Visibility.Collapsed;
            b4.Visibility = Visibility.Collapsed;



            a.Content = "Correct!";
            await Task.Delay(1000);
            this.Close();
        }
        // this code is ass, i dont care enough to make it better.
        public async void lose()
        {
            b1.Visibility = Visibility.Collapsed;
            b2.Visibility = Visibility.Collapsed;
            b3.Visibility = Visibility.Collapsed;
            b4.Visibility = Visibility.Collapsed;



            a.Content = "Incorrect!\n10s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n9s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n8s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n7s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n6s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n5s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n4s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n3s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n2s";
            await Task.Delay(1000);
            a.Content = "Incorrect!\n1s";
            await Task.Delay(1000);
            this.Close();
        }
        public async void b()
        {
            // hopefully fixes race condition
            await Task.Delay(5);
            a.Content = question.Name;
            b1.Content = question.Answers.Keys.ToList()[0].ToString();
            b2.Content = question.Answers.Keys.ToList()[1].ToString();
            b3.Content = question.Answers.Keys.ToList()[2].ToString();
            b4.Content = question.Answers.Keys.ToList()[3].ToString();
            a.Content = question.Name;



        }
    }
}
