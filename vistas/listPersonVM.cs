using Microsoft.Toolkit.Mvvm.ComponentModel;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.vistas
{
    class listPersonVM : ObservableObject
    {
        
        private ObservableCollection<Persona> personas;

        public ObservableCollection<Persona> Personas
        {
            get { return personas; }
            set { SetProperty(ref personas, value); }
        }

        private Persona p;

        public Persona P
        {
            get { return p; }
            set { SetProperty(ref p, value); }
        }

        public listPersonVM() {
            Personas = Persona.GetSamples();
            
        }
    }
}
