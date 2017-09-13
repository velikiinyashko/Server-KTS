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
using Server.Models;
using Server.Views;
using System.Data.Entity;

namespace Server
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        ServerConf Conf = new ServerConf();
        ConfigContext ConfigDb;
        
        public MainWindow()
        {
            InitializeComponent();
            ConfigDb = new ConfigContext();
            ConfigData.ItemsSource = ConfigDb.Config.ToList();
            if (ConfigData.ItemsSource == null)
            {
                CreateButton.IsEnabled = true;
            }
            this.DataContext = ConfigDb.Config.Local.ToBindingList();
        }

        public void CreateClick(object sender, RoutedEventArgs e)
        {
            Configuration configuration = new Configuration(new ServerConf());
            if(configuration.ShowDialog() == true)
            {
                ServerConf serverConf = configuration.Config;
                ConfigDb.Config.Add(serverConf);
                CreateButton.IsEnabled = false;
            }
            ConfigDb.SaveChanges();
        }
    }
}
