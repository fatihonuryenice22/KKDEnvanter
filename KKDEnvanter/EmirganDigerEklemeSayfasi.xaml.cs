﻿using KKDEnvanter.myModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
    /// EmirganDigerEklemeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EmirganDigerEklemeSayfasi : Window
    {
        private MyVariables _variables = new MyVariables();
        public EmirganDigerEklemeSayfasi()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            if (File.Exists("emirganData.txt"))
            {
                var json = File.ReadAllText("emirganData.txt");
                _variables = JsonConvert.DeserializeObject<MyVariables>(json);
            }
            else
            {
                _variables = new MyVariables();
            }
        }
        private void SaveData(MyVariables variables)
        {
            var json = JsonConvert.SerializeObject(variables, Formatting.Indented);
            File.WriteAllText("emirganData.txt", json);

        }
        private void updateValues()
        {
            //
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.dusEmirgan += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.aparatEmirgan += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.jelEmirgan += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {

            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.Diger1Emirgan += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {

            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.Diger2Emirgan += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {

            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.Diger3Emirgan += inputDialog.InputValue;
                SaveData(_variables);

            }
        }
    }
}
