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
    /// Interaction logic for Settings.xaml
    /// </summary>
    public partial class Settings : Window
    {
        bool init = true;
        public Settings()
        {
            InitializeComponent();
            LoadQuestions();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public void LoadQuestions()
        {
            questionbox.Items.Clear();
            intervalslider.Value = DataManager.instance.interval;
            intervallabel.Content = $"Interval: {DataManager.instance.interval}";
            foreach (Question q in DataManager.instance.questions)
            {
                questionbox.Items.Add(q.Name);
            }
        }

        private void intervalslider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (init)
            {
                init = false;
                return;
            }
            try
            {
                DataManager.instance.interval = (int)e.NewValue;
                if(intervallabel != null)
                {
                    intervallabel.Content = $"Interval: {DataManager.instance.interval}";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured! report this in the github repo\n" + ex, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            QuestionMaker maker = new QuestionMaker();
            maker.ShowDialog();
            LoadQuestions();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            LoadQuestions();
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            if(questionbox.SelectedIndex == -1)
            {
                MessageBox.Show("Select an item to remove!");
                return;
            }
            List<Question> temp = new List<Question>();
            int i = 0;
            foreach(Question q in DataManager.instance.questions) {
                if (i != questionbox.SelectedIndex)
                {
                    temp.Add(q);
                }
                i++;
            }
            DataManager.instance.questions = temp;
            LoadQuestions();
        }
    }
}
