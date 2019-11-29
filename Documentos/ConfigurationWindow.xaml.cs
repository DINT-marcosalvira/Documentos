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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para ConfigurationWindow.xaml
    /// </summary>
    public partial class ConfigurationWindow : Window
    {
        
        public int Alto { get; set; }
        public int Ancho { get; set; }

        public ConfigurationWindow()
        {
            InitializeComponent();
            AnchoTextBox.Text = this.Ancho.ToString();
            AltoTextBox.Text = this.Alto.ToString();
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Alto = int.Parse(AltoTextBox.Text.ToString());
            this.Ancho = int.Parse(AnchoTextBox.Text.ToString());
            DialogResult = true;
            Close();
        }

        private void CancelarButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
