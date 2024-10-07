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
    /// EtilerVucutKoruyucularSilmeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerVucutKoruyucularSilmeSayfasi : Window
    {
        public EtilerVucutKoruyucularSilmeSayfasi()
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
            EtilerİsEldiveniSilme etilerİsEldiveniSilme = new EtilerİsEldiveniSilme();
            etilerİsEldiveniSilme.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EtilerTyvekSilme etilerTyvekSilme = new EtilerTyvekSilme();
            etilerTyvekSilme.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EtilerYelekSilme etilerYelekSilme = new EtilerYelekSilme();
            etilerYelekSilme.Show();
            this.Close();
        }
    }
}
