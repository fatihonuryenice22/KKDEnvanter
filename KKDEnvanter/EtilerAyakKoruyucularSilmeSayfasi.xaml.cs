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
    /// EtilerAyakKoruyucularSilmeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerAyakKoruyucularSilmeSayfasi : Window
    {
        public EtilerAyakKoruyucularSilmeSayfasi()
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
            EtilerKislikAyakkabiSil etilerKislikAyakkabiSil = new EtilerKislikAyakkabiSil();
            etilerKislikAyakkabiSil.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EtilerKasıkÇizmesiSil etilerKasıkÇizmesiSil = new EtilerKasıkÇizmesiSil();
            etilerKasıkÇizmesiSil.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EtilerYGÇizmeSil etilerYGÇizmeSil = new EtilerYGÇizmeSil();
            etilerYGÇizmeSil.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EtilerÇizmeSil etilerÇizmeSil = new EtilerÇizmeSil();
            etilerÇizmeSil.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EtilerYazlikAyakkabiSil etilerYazlikAyakkabiSil = new EtilerYazlikAyakkabiSil();
            etilerYazlikAyakkabiSil.Show();
            this.Close();
        }
    }
}
