using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    public class PersonaViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this
                , new PropertyChangedEventArgs(propertyName));
        }

        private Persona _Persona;
        public Persona Persona
        {
            get { return this._Persona; }
            set {
                this._Persona = value;
                RaisePropertyChanged("Persona");
            }
        }

        private String _Descripcion;
        public String Descripcion
        {
            get { return this._Descripcion; }
            set
            {
                this._Descripcion = value;
                RaisePropertyChanged("Descripcion");
            }
        }

        public PersonaViewModel()
        {
            this.Persona = new Persona();
        }

        public Command MostrarDescripcion
        {
            get
            {
                return new Command(() =>
                {
                    this.Descripcion = "Nombre: "
                    + this.Persona.Nombre + ", Edad: "
                    + this.Persona.Edad;
                });
            }
        }

        public Command NewPerson
        {
            get
            {
                return new Command(() =>
                {
                    Persona p = new Persona();
                    p.Nombre = "Maria";
                    p.Edad = 37;
                    this.Persona = p;
                    //CAMBIAMOS LA DESCRIPCION, QUE DEPENDE DE LA PERSONA
                    this.Descripcion = "Nombre: "
                        + this.Persona.Nombre + ", Edad: "
                        + this.Persona.Edad;
                });
            }
        }
    }
}
