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

namespace Ejercicio_2
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

        private List<Escuela> Estudiante = new List<Escuela>();
        private void ButtonClick_Guardar(object sender, RoutedEventArgs e)
        {
            Guardar();

            MatriculaTextBox.Text = "";
            NombresTextBox.Text = "";
            FechaTextBox.Text = "";
            TelefonoTextBox.Text = "";
            GradoTextBox.Text = "";
            DireccionTextBox.Text = "";
        }
        private void Guardar()
        {
            Estudiante.Add(new Escuela(int.Parse(MatriculaTextBox.Text), NombresTextBox.Text, 
            FechaTextBox.Text, TelefonoTextBox.Text, GradoTextBox.Text, DireccionTextBox.Text));

        }
    }
}
