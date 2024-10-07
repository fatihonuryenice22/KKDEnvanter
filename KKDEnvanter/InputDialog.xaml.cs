using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// InputDialog.xaml etkileşim mantığı
    /// </summary>
    public partial class InputDialog : Window
    {
        public int InputValue { get; set; }
        public InputDialog()
        {
            
            InitializeComponent();
        }

       
        
            private void OkClick(object sender, RoutedEventArgs e)
            {
                if (int.TryParse(InputTextBox.Text, out int value))
                {
                    InputValue = value;
                    DialogResult = true;
                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Bir Sayı Girin");
                }
            }
        }
    }

