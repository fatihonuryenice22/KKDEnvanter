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
    /// EtilerKKDEklemeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerKKDEklemeSayfasi : Window
    {
        public EtilerKKDEklemeSayfasi()
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
            EtilerBaşKoruyucuEklemeSayfasi etilerBaşKoruyucuEklemeSayfasi = new EtilerBaşKoruyucuEklemeSayfasi();
            etilerBaşKoruyucuEklemeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EtilerKulakKoruyucuEklemeSayfasi etilerKulakKoruyucuEklemeSayfasi = new EtilerKulakKoruyucuEklemeSayfasi();
            etilerKulakKoruyucuEklemeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EtilerGozKoruyucularSayfasi etilerGozKoruyucularSayfasi = new EtilerGozKoruyucularSayfasi();
            etilerGozKoruyucularSayfasi.Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EtilerSolunumKoruyucularEklemeSayfasi etilerSolunumKoruyucularEklemeSayfasi = new EtilerSolunumKoruyucularEklemeSayfasi();
            etilerSolunumKoruyucularEklemeSayfasi .Show();
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EtilerVucutKoruyucularEklemeSayfasi etilerVucutKoruyucularEklemeSayfasi = new EtilerVucutKoruyucularEklemeSayfasi ();
            etilerVucutKoruyucularEklemeSayfasi.Show();
            this.Close();

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            EtilerAyakkoruyucuEklemeSayfasi etilerAyakkoruyucuEklemeSayfasi = new EtilerAyakkoruyucuEklemeSayfasi();
            etilerAyakkoruyucuEklemeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            EtilerYükseklikKoruyucularEklemeSayfasi etilerYükseklikKoruyucularEklemeSayfasi = new EtilerYükseklikKoruyucularEklemeSayfasi();
            etilerYükseklikKoruyucularEklemeSayfasi .Show();
            this.Close();
        }
    }
}
