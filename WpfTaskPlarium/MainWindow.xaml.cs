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

namespace WpfTaskPlarium
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonPoli_Click(object sender, RoutedEventArgs e)
        {
            PolindromWindow polindromWindow = new PolindromWindow();
            polindromWindow.Owner = this;
            polindromWindow.Show();
        }

        private void buttonSort_Click(object sender, RoutedEventArgs e)
        {
            SortWindow sortWindow = new SortWindow();
            sortWindow.Owner = this;
            sortWindow.Show();
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxButton Button = MessageBoxButton.YesNo;
            MessageBoxResult Result = MessageBox.Show("Вы уверены что хотите выйти из приложения?", "Выход", Button);
            if (Result == MessageBoxResult.Yes)
                System.Windows.Application.Current.Shutdown();
        }
    }
}
