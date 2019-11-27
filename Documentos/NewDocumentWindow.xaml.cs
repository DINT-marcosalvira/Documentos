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

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para NewDocumentWindow.xaml
    /// </summary>
    public partial class NewDocumentWindow : Window
    {
        public NewDocumentWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.SaveFileDialog dialogo = new Microsoft.Win32.SaveFileDialog();

            dialogo.Filter = "Archivos de texto|*.txt";
            dialogo.ShowDialog();
            string cadena = ContenidoTextBox.Text;

            File.WriteAllText(dialogo.FileName, cadena); 
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult m =  MessageBox.Show("¿Está seguro que quiere cerrar?", "CERRAR", System.Windows.MessageBoxButton.OKCancel, MessageBoxImage.Information);

            if (m == MessageBoxResult.OK)
            {
                return;
            }
            e.Cancel = true;
        }
    }
}
