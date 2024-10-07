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
    /// EtilerAyakkoruyucuEklemeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerAyakkoruyucuEklemeSayfasi : Window
    {
        public EtilerAyakkoruyucuEklemeSayfasi()
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
            EtilerKislikAyakkabiEkle etilerKislikAyakkabiEkle = new EtilerKislikAyakkabiEkle();
        etilerKislikAyakkabiEkle.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EtilerKasıkÇizmesiEkle etilerKasıkÇizmesiEkle = new EtilerKasıkÇizmesiEkle();
            etilerKasıkÇizmesiEkle.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EtilerYGÇizmeEkle etilerYGÇizmeEkle = new EtilerYGÇizmeEkle();
            etilerYGÇizmeEkle.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EtilerÇizmeEkle etilerÇizmeEkle = new EtilerÇizmeEkle();
            etilerÇizmeEkle.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EtilerYazlikAyakkabiEkle etilerYazlikAyakkabiEkle = new EtilerYazlikAyakkabiEkle();
            etilerYazlikAyakkabiEkle.Show();
            this.Close();

        }
    }
}
