using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pilas_ColasSimples_ColasCirculares
{
    class CNodo
    {
        string nombre;
        string marca;
        int horas;
        double precio;
        double total;
        CNodo siguiente = null;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Marca { get => marca; set => marca = value; }
        public int Horas { get => horas; set => horas = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Total { get => total; set => total = value; }
        internal CNodo Siguiente { get => siguiente; set => siguiente = value; }
    }
}
