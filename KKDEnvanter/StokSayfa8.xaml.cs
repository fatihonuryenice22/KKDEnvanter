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
    /// StokSayfa8.xaml etkileşim mantığı
    /// </summary>
    public partial class StokSayfa8 : Window
    {
        private MyVariables _variables = new MyVariables();
        public StokSayfa8()
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
                MyTextBlock.Text = _variables.tabelaEtiler.ToString();
            tabelaemirgan.Text = _variables.tabelaEmirgan.ToString();
            int tabela1 = _variables.tabelaEtiler;
            int tabela2 = _variables.tabelaEmirgan;
            int toplamtabela = tabela1 + tabela2;
            Toplam1.Text = toplamtabela.ToString();
            delinatoretiler.Text = _variables.delinatorEtiler.ToString();
            delinatoremirgan.Text = _variables.delintorEmirgan.ToString();
            int delinator1 = _variables.delinatorEtiler;
            int delinator2 = _variables.delintorEmirgan;
            int toplamdeli = delinator1 + delinator2;
            Toplam2.Text = toplamdeli.ToString();
            duba50etiler.Text = _variables.duba50Etiler.ToString();
            duba50emirgan.Text = _variables.duba50Emirgan.ToString();
            int duba501 = _variables.duba50Etiler;
            int duba502 = _variables.duba50Emirgan;
            int toplamduba50 = duba502 + duba501;
            Toplam3.Text = toplamduba50.ToString();
            duba90etiler.Text = _variables.duba90Etiler.ToString();
            duba90emirgan.Text = _variables.duba90Emirgan.ToString();
            int duba901 = _variables.duba90Etiler;
            int duba902 = _variables.duba90Emirgan;
            int toplamduba90 = duba902 + duba901;
            Topam4.Text = toplamduba90.ToString();
            seritetiler.Text = _variables.seritEtiler.ToString();
            seritemirgan.Text = _variables.seritEmirgan.ToString();
            int serit1 = _variables.seritEtiler;
            int serit2 = _variables.seritEmirgan;
            int toplamserit = serit2 + serit1;
            Toplam5.Text = toplamserit.ToString();
            bantetiler.Text = _variables.bantEtiler.ToString();
            bantemirgan.Text = _variables.bantEmirgan.ToString();
            int bant1 = _variables.bantEtiler;
            int bant2 = _variables.bantEmirgan;
            int toplambant = bant1 + bant2;
            Toplam6.Text = toplambant.ToString();
            abemirgan.Text = _variables.absorbEmirgan.ToString();
            abetiler.Text = _variables.absorbEtiler.ToString();
            int ab1 = _variables.absorbEmirgan;
            int ab2 = _variables.absorbEtiler;
            int toplamab = ab1 + ab2;
            Toplam7.Text = toplamab.ToString();
            paspasemirgan.Text = _variables.paspasEmirgan.ToString();
            paspasetiler.Text = _variables.paspasEtiler.ToString();
            int paspas1 = _variables.paspasEmirgan;
            int paspas2 = _variables.paspasEtiler;
            int toplampaspas = paspas1 + paspas2;
            Toplam8.Text = toplampaspas.ToString();

            {
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            StokSayfa9 stokSayfa9 = new StokSayfa9();
            stokSayfa9.Show();
            this.Close();
        }
    }
}
