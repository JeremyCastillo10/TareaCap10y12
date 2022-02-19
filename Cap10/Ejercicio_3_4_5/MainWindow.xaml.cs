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

namespace Ejercicio_3
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
        private void ButtonClick_Calcular(object sender, RoutedEventArgs e)
        {
            Poligono triangulo= new Poligono(int.Parse(L1txt.Text), int.Parse(L2txt.Text), int.Parse(L3txt.Text));
            MessageBox.Show(triangulo.Validar(int.Parse(L1txt.Text), int.Parse(L2txt.Text), int.Parse(L3txt.Text)));
            Perimetrotxt.Text =  triangulo.ToString();
        }
        
    }
}
