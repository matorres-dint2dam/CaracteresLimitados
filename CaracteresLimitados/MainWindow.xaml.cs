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

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AumentarContador(  ) 
        {
            String caracteres = caja.Text.Length.ToString();
            contador.Text = caracteres + "/140";
        }

        private void BloquearCaja()
        {
            if (caja.Text.Length == 140)
            {
                caja.IsEnabled = false;
            }
        }

        private void caja_TextChanged(object sender, TextChangedEventArgs e)
        {
            caja_TextChanged(sender, e);
            AumentarContador();
            BloquearCaja();
        }
    }
}
