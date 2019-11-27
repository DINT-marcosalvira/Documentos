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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Documentos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _alto = 200;
        private int _ancho = 200;

        public void setAlto(int Alto)
        {
            this._alto = Alto;
        }

        public void setAncho(int Ancho)
        {
            this._ancho = Ancho;
        }

        public int getAlto()
        {
            return _alto;
        }

        public int getAncho()
        {
            return _ancho;
        }

        public MainWindow()
        {
            InitializeComponent();
        }

        private void NuevoButton_Click(object sender, RoutedEventArgs e)
        {
            NewDocumentWindow nd = new NewDocumentWindow();
            
            nd.Owner = this;
            nd.Title = "Documento " + this.OwnedWindows.Count.ToString();
            nd.Width = this.getAncho();
            nd.Height = this.getAlto();
            nd.Show();
        }

        private void ConfButton_Click(object sender, RoutedEventArgs e)
        {
            ConfigurationWindow cw = new ConfigurationWindow();
            cw.Owner = this;
            cw.Ancho = 200;
            cw.Alto = 200;
            cw.ShowDialog();
            this.setAlto(cw.Alto);
            this.setAncho(cw.Ancho);
        }
    }
}
