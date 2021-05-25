using PaginasBinding.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaginasBinding.Models
{
    public class ListaNumeros
    {
        public List<NumerosViewModel> Numeros
        {
            get
            {
                Random random = new Random();
                List<NumerosViewModel> lista = 
                    new List<NumerosViewModel>();
                for (int i = 1; i <= 17; i++)
                {
                    int valor = random.Next(-25, 25);
                    NumerosViewModel model = new NumerosViewModel();
                    model.Valor = valor;
                    lista.Add(model);
                }
                return lista;
            }
        }
    }
}
