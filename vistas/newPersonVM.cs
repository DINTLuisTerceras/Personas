using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using Microsoft.Toolkit.Mvvm.Messaging;
using Personas.controls;
using Personas.modelos;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Personas.vistas
{
    class newPersonVM : ObservableObject
    {
        public RelayCommand OpenAddPerson { get; }
        public RelayCommand Accept_AddToList { get; }

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

        private ObservableCollection<string> paises;
        public ObservableCollection<string> Paises
        {   
            get { return paises; }
            set { SetProperty(ref paises, value); }
        }

        private Persona persona;

        public Persona Persona
        {
            get { return persona; }
            set { SetProperty(ref persona, value); }
        }


        public newPersonVM() 
        {
            Accept_AddToList = new RelayCommand(AddToList);
            
            Paises = new ObservableCollection<string> { "España", "Portugal", "Italia" };

            WeakReferenceMessenger.Default.Register<TextoModificadoMessage>
                (this, (r, m) =>
                {
                    Paises.Add(m.Value.ToString());
                });
        }

        public void AddToList() 
        {
            WeakReferenceMessenger.Default.Register <newPersonVM, EnviarNombre>
                (this, (r, m) =>
                {
                    m.Reply(r.Nombre);
                });

            WeakReferenceMessenger.Default.Register<newPersonVM, EnviarEdad>
                (this, (r, m) =>
                {
                    m.Reply(r.Edad);
                });

            WeakReferenceMessenger.Default.Register<newPersonVM, EnviarPais>
                (this, (r, m) =>
                {
                    m.Reply(r.Pais);
                });
        }
    }
}
