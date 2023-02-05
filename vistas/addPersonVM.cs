using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vistas
{
    class addPersonVM : ObservableObject
    {
        public RelayCommand aceptarNacion { get; }

        private string nacionalidad;

        public string Nacionalidad
        {
            get { return nacionalidad; }
            set { SetProperty(ref nacionalidad, value); }
        }

        public addPersonVM() 
        {
            aceptarNacion = new RelayCommand(añadirPais);
        }

        public void añadirPais()
        {
            WeakReferenceMessenger.Default.Send(new TextoModificadoMessage(Nacionalidad));
        }
    }
}
