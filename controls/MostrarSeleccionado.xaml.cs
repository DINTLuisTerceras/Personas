using Personas.vistas;
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

namespace Personas.controls
{
    /// <summary>
    /// Lógica de interacción para MostrarSeleccionado.xaml
    /// </summary>
    public partial class MostrarSeleccionado : UserControl
    {
        MostrarSeleccionadoVM vm;
        public MostrarSeleccionado()
        {
            InitializeComponent();
            vm = new MostrarSeleccionadoVM();
            this.DataContext = vm;
        }
    }
}
