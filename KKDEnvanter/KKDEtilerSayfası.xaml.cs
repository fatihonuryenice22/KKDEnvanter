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
    /// KKDEtilerSayfası.xaml etkileşim mantığı
    /// </summary>
    public partial class KKDEtilerSayfası : Window
    {
        public KKDEtilerSayfası()
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
            EtilerBasKoruyucularSilmeSayfasi etilerBasKoruyucularSilmeSayfasi = new EtilerBasKoruyucularSilmeSayfasi();
            etilerBasKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EtilerKulakKoruyucularSilmeSayfasi etilerKulakKoruyucularSilmeSayfasi = new EtilerKulakKoruyucularSilmeSayfasi();
            etilerKulakKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EtilerGozKoruyucularSilmeSayfasi etilerGozKoruyucularSilmeSayfasi = new EtilerGozKoruyucularSilmeSayfasi();
            etilerGozKoruyucularSilmeSayfasi .Show();
            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            EtilerSolunumKoruyucularSilmeSayfasi etilerSolunumKoruyucularSilmeSayfasi = new EtilerSolunumKoruyucularSilmeSayfasi();
            etilerSolunumKoruyucularSilmeSayfasi.Show(); 
            this.Close();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            EtilerVucutKoruyucularSilmeSayfasi etilerVucutKoruyucularSilmeSayfasi = new EtilerVucutKoruyucularSilmeSayfasi();
            etilerVucutKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            EtilerAyakKoruyucularSilmeSayfasi etilerAyakKoruyucularSilmeSayfasi = new EtilerAyakKoruyucularSilmeSayfasi();
            etilerAyakKoruyucularSilmeSayfasi.Show();
            this.Close();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            EtilerYükseklikKoruyucularSilmeSayfasi etilerYükseklikKoruyucularSilmeSayfasi = new EtilerYükseklikKoruyucularSilmeSayfasi();
            etilerYükseklikKoruyucularSilmeSayfasi .Show();
            this.Close();
        }
    }
}
