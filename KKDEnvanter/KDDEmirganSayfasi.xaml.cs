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
    /// KDDEmirganSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class KDDEmirganSayfasi : Window
    {
        public KDDEmirganSayfasi()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmirganBasKoruyucularSilmeSayfasi emirganBasKoruyucularSilmeSayfasi = new EmirganBasKoruyucularSilmeSayfasi();
            emirganBasKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmirganKulakKoruyucularSilmeSayfasi emirganKulakKoruyucularSilmeSayfasi = new EmirganKulakKoruyucularSilmeSayfasi();
            emirganKulakKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmirganGozKoruyucularSilmeSayfasi emirganGozKoruyucularSilmeSayfasi = new EmirganGozKoruyucularSilmeSayfasi();
            emirganGozKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EmirganSolunumKoruyucularSilmeSayfasi emirganSolunumKoruyucularSilmeSayfasi = new EmirganSolunumKoruyucularSilmeSayfasi();
            emirganSolunumKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EmirganVücutKoruyucularSilmeSayfasi emirganVücutKoruyucularSilmeSayfasi = new EmirganVücutKoruyucularSilmeSayfasi();
            emirganVücutKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            EmirganAyakKoruyucularSilmeSayfasi emirganAyakKoruyucularSilmeSayfasi = new EmirganAyakKoruyucularSilmeSayfasi();
            emirganAyakKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            EmirganYükseklikKoruyucularSilmeSayfasi emirganYükseklikKoruyucularSilmeSayfasi = new EmirganYükseklikKoruyucularSilmeSayfasi();
            emirganYükseklikKoruyucularSilmeSayfasi.Show();
            this.Close();
        }
    }
}
