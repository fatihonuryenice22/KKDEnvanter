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
    /// EmirganAyakKoruyucular.xaml etkileşim mantığı
    /// </summary>
    public partial class EmirganAyakKoruyucular : Window
    {
        public EmirganAyakKoruyucular()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmirganKislikAyakkabiEkle emirganKislikAyakkabiEkle = new EmirganKislikAyakkabiEkle();
            emirganKislikAyakkabiEkle.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmirganKasıkÇizmesiEkle emirganKasıkÇizmesiEkle = new EmirganKasıkÇizmesiEkle();
            emirganKasıkÇizmesiEkle.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmirganYGÇizmeEkle emirganYGÇizmeEkle = new EmirganYGÇizmeEkle();
            emirganYGÇizmeEkle.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EmirganÇizmeEkle emirganÇizmeEkle = new EmirganÇizmeEkle();
            emirganÇizmeEkle.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EmirganYazlikAyakkabiEkle emirganYazlikAyakkabiEkle = new EmirganYazlikAyakkabiEkle();
            emirganYazlikAyakkabiEkle.Show();
            this.Close();
        }
    }
}
