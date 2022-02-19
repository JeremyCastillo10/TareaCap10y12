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
using Cap10.Entidades;

namespace Ejercicio_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private List<Tienda> producto = new List<Tienda>();
        private void ButtonClick_Guardar(object sender, RoutedEventArgs e)
        {
            Guardar();

            CodigoTextBox.Text = "";
            DescripcionTextBox.Text = "";
            ExistenciaTextBox.Text = "";
            CostoTextBox.Text = "";
        }
        private void Guardar()
        {
            producto.Add(new Tienda(int.Parse(CodigoTextBox.Text), DescripcionTextBox.Text, 
            int.Parse(ExistenciaTextBox.Text), float.Parse(CostoTextBox.Text)));

        }
    }
}
