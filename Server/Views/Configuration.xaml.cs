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

namespace Server.Views
{
    /// <summary>
    /// Логика взаимодействия для Configuration.xaml
    /// </summary>
    public partial class Configuration : Window
    {
        public Models.ServerConf Config { get; private set; }

        public Configuration(Models.ServerConf Config)
        {
            InitializeComponent();
            this.Config = Config;
            this.DataContext = this.Config;
        }

        private void AccessClick(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}
