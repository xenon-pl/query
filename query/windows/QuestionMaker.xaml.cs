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
using query.impl;
namespace query
{
    /// <summary>
    /// Interaction logic for QuestionMaker.xaml
    /// </summary>
    public partial class QuestionMaker : Window
    {
        public QuestionMaker()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(@"Help:
'Question' will be the question title
The four textboxes under will be the four anwsers
the checkboxes under the textboxes will determine wether the question is 'correct'
");
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Dictionary<string, bool> keyValuePairs = new Dictionary<string, bool>();
            // there is definetly a better way to do this, but i dont care since it works
            keyValuePairs.Add(q1.Text, (bool)q1correct.IsChecked);
            keyValuePairs.Add(q2.Text, (bool)q2correct.IsChecked);
            keyValuePairs.Add(q3.Text, (bool)q3correct.IsChecked);
            keyValuePairs.Add(q4.Text, (bool)q4correct.IsChecked);

            DataManager.instance.questions.Add(new Question(QuestionBox.Text, keyValuePairs));
            Close();
        }
    }
}
