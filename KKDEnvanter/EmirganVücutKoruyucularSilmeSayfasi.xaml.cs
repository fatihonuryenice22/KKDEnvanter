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
    /// EmirganVücutKoruyucularSilmeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EmirganVücutKoruyucularSilmeSayfasi : Window
    {
        public EmirganVücutKoruyucularSilmeSayfasi()
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
            EmirganİsEldiveniSilme emirganİsEldiveniSilme = new EmirganİsEldiveniSilme();
            emirganİsEldiveniSilme.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EmirganTyvekSilme emirganTyvekSilme= new EmirganTyvekSilme();
            emirganTyvekSilme.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EmirganYelekSilme emirganYelekSilme = new EmirganYelekSilme();
            emirganYelekSilme.Show();
            this.Close();   
        }
    }
}
