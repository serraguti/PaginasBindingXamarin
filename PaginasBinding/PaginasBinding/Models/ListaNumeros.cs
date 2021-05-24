using System;
using System.Collections.Generic;
using System.Text;

namespace PaginasBinding.Models
{
    public class ListaNumeros
    {
        public List<int> Numeros
        {
            get
            {
                Random random = new Random();
                List<int> lista = new List<int>();
                for (int i = 1; i <= 17; i++)
                {
                    int valor = random.Next(-25, 25);
                    lista.Add(valor);
                }
                return lista;
            }
        }
    }
}
