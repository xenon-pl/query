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

namespace query.windows
{
    /// <summary>
    /// Interaction logic for Background.xaml
    /// </summary>
    public partial class Background : Window
    {
        public static Background instance;
        public bool shouldOpen;
        public Background()
        {
            InitializeComponent();
            instance = this;
            MainWindow mw = new MainWindow();
            mw.ShowDialog();
            if (!mw.configed)
            {
                Application.Current.Shutdown();
                return;
            }
            Open();

        }

        public async void Open()
        {
            if (shouldOpen)
            {
                Random rand = new Random();
                int rn = rand.Next(0, DataManager.instance.questions.Count - 1);
                questionwindow qw = new questionwindow();
                qw.question = DataManager.instance.questions[rn];
                qw.Show();

            }

            await Task.Delay(DataManager.instance.interval * 60000);

            
            Open();
        }
    }
}
