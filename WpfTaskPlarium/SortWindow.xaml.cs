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
    /// Логика взаимодействия для SortWindow.xaml
    /// </summary>
    public partial class SortWindow : Window
    {
        public SortWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            textBox.Clear();
            textBox2.Clear();
            int[] RandArr = new int[8];
            int[] arr2 = new int[8];
            Random RandNum = new Random();
            for (int i = 0; i < RandArr.Length; i++)
            {
                RandArr[i] = RandNum.Next(0, 20);
            }
            foreach(int i in RandArr)
            {
                textBox.Text += " " + i;
            }
            sortArray(RandArr, arr2);

        }

        private void sortArray(int[]RandArr, int[] arr2)
        {
            int cnt = 0;

            for (int i = 0; i < RandArr.Length; i++)
            {
                if (((RandArr[i] % 2) == 0) && (RandArr[i] != 0))
                {
                    arr2[cnt] = RandArr[i];
                    cnt++;
                }
            }

            //zero num
            for (int i = 0; i < RandArr.Length; i++)
            {
                if (RandArr[i] == 0)
                {
                    arr2[cnt] = RandArr[i];
                    cnt++;
                }
            }

            //odd num
            for (int i = 0; i < RandArr.Length; i++)
            {
                if ((RandArr[i] % 2) != 0)
                {
                    arr2[cnt] = RandArr[i];
                    cnt++;
                }
            }
            foreach (int i in arr2)
            {
                textBox2.Text += " " + i;
            }

        }
    }
}
