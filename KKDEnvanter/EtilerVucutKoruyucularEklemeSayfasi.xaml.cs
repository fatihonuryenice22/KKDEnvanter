﻿using System;
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
    /// EtilerVucutKoruyucularEklemeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerVucutKoruyucularEklemeSayfasi : Window
    {
        public EtilerVucutKoruyucularEklemeSayfasi()
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
            EtilerİsEldiveniEkleme etilerİsEldiveniEkleme = new EtilerİsEldiveniEkleme();
            etilerİsEldiveniEkleme.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            EtilerTyvekEkleme etilerTyvekEkleme = new EtilerTyvekEkleme();
            etilerTyvekEkleme.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            EtilerYelekEkleme etilerYelekEkleme = new EtilerYelekEkleme();
            etilerYelekEkleme.Show();
            this.Close();
        }
    }
}
