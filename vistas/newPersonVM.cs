using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Personas.controls;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.vistas
{
    class newPersonVM : ObservableObject
    {
        private RelayCommand OpenAddPerson { get; }

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

        private List<string> paises;
        public List<string> Paises
        {
            get { return paises; }
            set { SetProperty(ref paises, value); }
        }

        public newPersonVM() 
        {
            Paises = new List<string> { "España", "Portugal", "Italia" };
        }
    }
}
