using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vistas
{
    class MostrarSeleccionadoVM : ObservableObject
    {
        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }

        private string pais;

        public string Pais
        {
            get { return pais; }
            set { SetProperty(ref pais, value); }
        }

        public MostrarSeleccionadoVM ()
        {
            Nombre = WeakReferenceMessenger.Default.Send<SendNameSelect>();
            Edad = WeakReferenceMessenger.Default.Send<SendAgeSelect>();
            Pais = WeakReferenceMessenger.Default.Send<SendCountrySelect>();
        }
    }
}
