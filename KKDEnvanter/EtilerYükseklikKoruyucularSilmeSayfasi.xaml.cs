using KKDEnvanter.myModels;
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
    /// EtilerYükseklikKoruyucularSilmeSayfasi.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerYükseklikKoruyucularSilmeSayfasi : Window
    {
        private MyVariables _variables = new MyVariables();
        public EtilerYükseklikKoruyucularSilmeSayfasi()
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
            EtilerParaşütSilme etilerParaşütSilme = new EtilerParaşütSilme();
            etilerParaşütSilme.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.BelEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.perlonEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.karabinaEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.sapanEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.celikHalatEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.makaraEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.halat50Etiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.cantaEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.jumarEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.lanyardEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.halat100Etiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.halatEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.ayakcakEtiler -= inputDialog.InputValue;
                SaveData(_variables);

            }
        }

    }
}
