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
    /// EtilerYGÇizmeEkle.xaml etkileşim mantığı
    /// </summary>
    public partial class EtilerYGÇizmeEkle : Window
    {
        private MyVariables _variables = new MyVariables();
        public EtilerYGÇizmeEkle()
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
                _variables.YGCizmeEtiler36 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler37 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler38 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler39 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler40 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler41 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler42 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler43 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler44 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler45 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler46 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler47 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            InputDialog inputDialog = new InputDialog();
            if (inputDialog.ShowDialog() == true)
            {
                _variables.YGCizmeEtiler48 += inputDialog.InputValue;
                SaveData(_variables);

            }
        }
    }
}
