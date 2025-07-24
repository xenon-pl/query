using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using query.impl;
using query.windows;

namespace query
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool configed = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DataManager.instance.questions.Count == 0)
            {
                MessageBox.Show("You haven't added any questions. add a few in settings!");
                return;
            }
            configed = true;
            query.windows.Background.instance.shouldOpen = true;
            this.Close();

        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        
    }
}