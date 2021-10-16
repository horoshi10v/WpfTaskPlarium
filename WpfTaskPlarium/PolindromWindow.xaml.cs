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

namespace WpfTaskPlarium
{
    /// <summary>
    /// Логика взаимодействия для PolindromWindow.xaml
    /// </summary>
    public partial class PolindromWindow : Window
    {
        public PolindromWindow()
        {
            InitializeComponent();
        }
        
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int inputNum = isDigit(textBox.Text);
            int r, sum = 0, temp;
            temp = inputNum;

            while (inputNum > 0)
            {
                r = inputNum % 10;
                sum = (sum * 10) + r;
                inputNum = inputNum / 10;
            }

            if (temp == sum)
                MessageBox.Show("Число является полиндромом");
            else
                MessageBox.Show("Число не является полиндромом");
        }

        public static int isDigit(string str)
        {
            if (str.Any(c => char.IsLetter(c)) || str == "")
            {
                if (str != "")
                    MessageBox.Show("Вводить можно только числа");
                return -1;
            }
            else
                return (int)uint.Parse(str);
        }
    }
}
