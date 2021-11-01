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

namespace WpfApp5
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

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            zn_1.Clear();
            zn_2.Clear();
            rez_1.Clear();
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            zn.Clear();
            rez_2.Clear();
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №17 Вариант №6");
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
            int x1, x2;
            double d;
            x1 = Convert.ToInt32(zn_1.Text);
            x2 = Convert.ToInt32(zn_2.Text);
            if (x1 > 0 && x2 > 0)
            {
                d = x1 * x2;
                d = Math.Sqrt(d);
                rez_1.Text = Convert.ToString(d);
            }
            else MessageBox.Show("Введите правильные значения");
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            int a, x6, x8, x9, x10, x11, x13;
            bool f2;
            f2 = Int32.TryParse(zn.Text, out a);
            if(f2 && a < 1000 && a / 100 !=0)
            {
                x6 = a % 10; // последнее число
                x8 = (a % 100) / 10; // второе число
                x9 = x8 * 100;
                x10 = a / 100; // первое число
                x13 = x10 * 10;
                x11 = x9 + x6 + x13;
                rez_2.Text = Convert.ToString(x11);
            }
            else MessageBox.Show("Введите правильные значения");
        }
    }
}
