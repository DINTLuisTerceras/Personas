using Microsoft.Toolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personas.modelos
{
    class Persona : ObservableObject
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { SetProperty(ref nombre, value); }
        }


        private int edad;

        public int Edad
        {
            get { return edad; }
            set { SetProperty(ref edad, value); }
        }


        private string pais;

        public string Pais
        {
            get { return pais; }
            set { SetProperty(ref pais, value); }
        }

        public Persona(string nombre, int edad, string pais)
        {
            this.Nombre = nombre;
            this.Edad = edad;
            this.Pais = pais;
        }

        public static ObservableCollection<Persona> GetSamples()
        {
            ObservableCollection<Persona> personas = new ObservableCollection<Persona>();

            Persona p1 = new Persona("Stephen", 30, "Italia");
            Persona p2 = new Persona("Tatum", 0, "España");
            Persona p3 = new Persona("Antetokoumpo", 24, "Portugal");

            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);

            return personas;
        }
    }
}
