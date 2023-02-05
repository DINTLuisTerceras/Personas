using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Messaging;
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

        public listPersonVM() {
            Personas = Persona.GetSamples();

            Nombre = WeakReferenceMessenger.Default.Send<EnviarNombre>();
            Edad = WeakReferenceMessenger.Default.Send<EnviarEdad>();
            Pais = WeakReferenceMessenger.Default.Send<EnviarPais>();

            WeakReferenceMessenger.Default.Register<listPersonVM, SendNameSelect>
                (this, (r, m) =>
                {
                    m.Reply(r.P.Nombre);
                });

            WeakReferenceMessenger.Default.Register<listPersonVM, SendAgeSelect>
                (this, (r, m) =>
                {
                    m.Reply(r.P.Edad);
                });

            WeakReferenceMessenger.Default.Register<listPersonVM, SendCountrySelect>
                (this, (r, m) =>
                {
                    m.Reply(r.P.Pais);
                });

            Personas.Add(new Persona(Nombre, Edad, Pais));
        }
    }
}
