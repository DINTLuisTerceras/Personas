using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas
{
    class MainWindowVM : ObservableObject
    {
        public RelayCommand UC1Command { get; }
        public RelayCommand UC2Command { get; }

        public RelayCommand UC3Command { get; }

        private UserControl contenidoVentana;
        public UserControl ContenidoVentana
        {
            get { return contenidoVentana; }
            set { SetProperty(ref contenidoVentana, value); }
        }

        public MainWindowVM() 
        {
            UC1Command = new RelayCommand(OpenListPerson);
            UC2Command = new RelayCommand(OpenNewPerson);
            UC3Command = new RelayCommand(OpenMostrarSeleccionada);
        }

        public void OpenNewPerson()
        {
            ContenidoVentana = new newPerson();
        }

        public void OpenListPerson()
        {
            ContenidoVentana = new listPerson();
        }

        public void OpenMostrarSeleccionada() 
        {
            ContenidoVentana = new MostrarSeleccionado();
        }
    }
}
