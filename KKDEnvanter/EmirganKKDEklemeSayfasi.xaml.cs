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
    /// EmirganKKDEklemeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EmirganKKDEklemeSayfasi : Window
    {
        public EmirganKKDEklemeSayfasi()
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
            EmirganBaşKoruyucuEklemeSayfası emirganBaşKoruyucuEklemeSayfası = new EmirganBaşKoruyucuEklemeSayfası();
            emirganBaşKoruyucuEklemeSayfası.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmirganKulakKoruyucuEklemeSayfası emirganKulakKoruyucuEklemeSayfası = new EmirganKulakKoruyucuEklemeSayfası();
            emirganKulakKoruyucuEklemeSayfası.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmirganGözKoruyucularSayfası emirganGözKoruyucularSayfası = new EmirganGözKoruyucularSayfası();
            emirganGözKoruyucularSayfası.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EmirganSolunumKoruyucular emirganSolunumKoruyucular = new EmirganSolunumKoruyucular();
            emirganSolunumKoruyucular.Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EmirganVücutKoruyucular emirganVücutKoruyucular = new EmirganVücutKoruyucular();
            emirganVücutKoruyucular.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            EmirganAyakKoruyucular emirganAyakKoruyucular = new EmirganAyakKoruyucular();
            emirganAyakKoruyucular.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            EmirganYükseklikKoruyucuEkleme emirganYükseklikKoruyucuEkleme = new EmirganYükseklikKoruyucuEkleme();
            emirganYükseklikKoruyucuEkleme.Show();
            this.Close();
        }
    }
}
