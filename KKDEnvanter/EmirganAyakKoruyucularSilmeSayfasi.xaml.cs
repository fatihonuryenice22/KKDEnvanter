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

namespace KKDEnvanter
{
    /// <summary>
    /// EmirganAyakKoruyucularSilmeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EmirganAyakKoruyucularSilmeSayfasi : Window
    {
        public EmirganAyakKoruyucularSilmeSayfasi()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmirganKislikAyakkabiSil emirganKislikAyakkabiSil = new EmirganKislikAyakkabiSil();
            emirganKislikAyakkabiSil.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmirganYGÇizmeSil emirganYGÇizmeSil = new EmirganYGÇizmeSil();
            emirganYGÇizmeSil.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EmirganÇizmeSil emirganÇizmeSil = new EmirganÇizmeSil();
            emirganÇizmeSil.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EmirganYazlikAyakkabiSil emirganYazlikAyakkabiSil = new EmirganYazlikAyakkabiSil();
            emirganYazlikAyakkabiSil.Show();
            this.Close();
        }
    }
}
