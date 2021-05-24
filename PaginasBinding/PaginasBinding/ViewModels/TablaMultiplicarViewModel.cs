using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    public class TablaMultiplicarViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String propertyName)
        {
            PropertyChanged?.Invoke(this,
                new PropertyChangedEventArgs(propertyName));
        }
        //PROPIEDAD PARA SER ENLAZADA CON LA CAJA DE XAML
        //NO HACE FALTA EXTENDERLA PARA ESTE EJEMPLO
        private int _Numero;
        public int Numero
        {
            get { return this._Numero; }
            set
            {
                this._Numero = value;
                RaisePropertyChanged("Numero");
            }
        }

        //NECESITAMOS DIBUJAR EL CONJUNTO DE DATOS DE 
        //LA TABLA DE MULTIPLICAR.
        //SI QUEREMOS QUE LA VISTA PUEDA VISUALIZAR LOS CAMBIOS
        //SI ES IMPRESCINDIBLE QUE TENGAMOS LA PROPIEDAD EXTENDIDA
        private List<ModelTabla> _Tabla;
        public List<ModelTabla> Tabla
        {
            get { return this._Tabla; }
            set
            {
                this._Tabla = value;
                RaisePropertyChanged("Tabla");
            }
        }

        //PARA SEPARAR UN POCO EL CODIGO, CREAMOS UN METODO
        //PRIVADO PARA GENERAR LOS DATOS DE LA TABLA
        private List<ModelTabla> GenerarTabla()
        {
            List<ModelTabla> tabla = new List<ModelTabla>();
            for (int i = 1; i <= 10; i++)
            {
                ModelTabla model = new ModelTabla()
                {
                    Operacion = i + " * " + this.Numero,
                    Resultado = i * this.Numero
                };
                tabla.Add(model);
            }
            return tabla;
        }

        //NECESITAMOS CAPTURAR LA ACCION DE PULSAR EL BOTON
        //DE XAML
        public Command MostrarTabla
        {
            get
            {
                return new Command(() =>
                {
                    this.Tabla = this.GenerarTabla();
                });
            }
        }
    }
}
