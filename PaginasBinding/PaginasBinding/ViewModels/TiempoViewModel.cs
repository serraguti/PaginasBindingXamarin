using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace PaginasBinding.ViewModels
{
    public class TiempoViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(String PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,
                    new PropertyChangedEventArgs(PropertyName));
            }
        }
        private DateTime _Tiempo;
        public DateTime Tiempo { get {
                return this._Tiempo;
            } set {
                this._Tiempo = DateTime.Now;
                RaisePropertyChanged("Tiempo");
            } }

        public String Anyo { get; set; }
        public String Mes { get; set; }
        public String Dia { get; set; }
        //DEBEMOS HACER LAS PROPIEDADES EXTENDIDAS
        private String _Hora;

        public String Hora {
            get { return this._Hora; }
            set
            {
                this._Hora = value;
                RaisePropertyChanged("Hora");
            }
        }
        public TiempoViewModel()
        {
            this.Dia = DateTime.Now.DayOfWeek.ToString();
            this.Mes = DateTime.Now.ToString("MMMM");
            this.Anyo = "Year: " + DateTime.Now.Year;
            this.Hora = DateTime.Now.ToLongTimeString();
            this.Tiempo = DateTime.Now;
            //NECESITAMOS QUE LA HORA CAMBIE, PARA ELLO
            //VAMOS A REALIZARLO DESDE AQUI
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
             {
                 this.Tiempo = DateTime.Now;
                 this.Hora = DateTime.Now.ToLongTimeString();
                 return true;
             });
        }
    }
}
