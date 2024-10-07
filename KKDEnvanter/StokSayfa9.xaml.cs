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
    /// StokSayfa9.xaml etkileşim mantığı
    /// </summary>
    public partial class StokSayfa9 : Window
    {
        private MyVariables _variables = new MyVariables();
        public StokSayfa9()
        {
            InitializeComponent();
            LoadData();
            DisplayData();
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
        private void DisplayData()
        {
            if (_variables != null)
            {
                MyTextBlock.Text=_variables.dusEtiler.ToString();
                gozdusuemirgan.Text=_variables.dusEmirgan.ToString();
                int dus1 = _variables.dusEtiler;
                int dus2=_variables.dusEmirgan;
                int toplamdus=dus1 + dus2;
                Toplam1.Text=toplamdus.ToString();
                aparatemirgan.Text=_variables.aparatEmirgan.ToString() ;
                aparatetiler.Text=_variables.aparatEtiler.ToString();
                int aparat1 = _variables.aparatEtiler;
                int aparat2 = _variables.aparatEmirgan;
                int toplamaparat= aparat2+ aparat1;
                Toplam2.Text=toplamaparat.ToString();
                jeletiler.Text=_variables.jelEtiler.ToString();
                jelemirgan.Text = _variables.jelEmirgan.ToString();
                int jel1 = _variables.jelEtiler;
                int jel2= _variables.jelEmirgan;
                int toplamjel= jel1 + jel2;
                Toplam3.Text=toplamjel.ToString();
                diger1etiler.Text=_variables.Diger1Etiler.ToString();
                diger1emirgan.Text = _variables.Diger1Emirgan.ToString();
                int diger1=_variables.Diger1Emirgan;
                int diger2= _variables.Diger1Etiler;
                int toplamdiger1 = diger1 + diger2;
                toplamdiger.Text=toplamdiger1.ToString();
                diger2etiler.Text = _variables.Diger2Etiler.ToString();
                diger2emirgan.Text = _variables.Diger2Emirgan.ToString();
                int diger3 = _variables.Diger2Emirgan;
                int diger4 = _variables.Diger2Etiler;
                int toplamdigerx2 = diger3 + diger4;
                toplamdiger2.Text = toplamdigerx2.ToString();
                diger3etiler.Text = _variables.Diger3Etiler.ToString();
                diger3emirgan.Text = _variables.Diger3Emirgan.ToString();
                int diger5 = _variables.Diger3Emirgan;
                int diger6 = _variables.Diger3Etiler;
                int toplamdigerx3 = diger3 + diger4;
                toplamdiger3.Text = toplamdigerx3.ToString();
                diger2etiler_Kopyala1.Text = _variables.SgiDiger1Etiler.ToString();
                diger2emirgan_Kopyala1.Text = _variables.SgiDiger1Emirgan.ToString();
                int diger11 = _variables.SgiDiger1Emirgan;
                int diger21 = _variables.SgiDiger1Etiler;
                int toplamdiger11 = diger11 + diger21;
                toplamdiger2_Kopyala1.Text = toplamdiger11.ToString();
                diger2etiler_Kopyala.Text = _variables.SgiDiger2Etiler.ToString();
                diger2emirgan_Kopyala.Text = _variables.SgiDiger2Emirgan.ToString();
                int diger31 = _variables.SgiDiger2Emirgan;
                int diger41 = _variables.SgiDiger2Etiler;
                int toplamdigerx21 = diger31 + diger41;
                toplamdiger2_Kopyala.Text = toplamdigerx21.ToString();
                diger3etiler_Kopyala.Text = _variables.SgiDiger3Etiler.ToString();
                diger3emirgan_Kopyala.Text = _variables.SgiDiger3Emirgan.ToString();
                int diger51 = _variables.SgiDiger3Emirgan;
                int diger61 = _variables.SgiDiger3Etiler;
                int toplamdigerx31 = diger31 + diger41;
                toplamdiger3_Kopyala.Text = toplamdigerx31.ToString();



            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
