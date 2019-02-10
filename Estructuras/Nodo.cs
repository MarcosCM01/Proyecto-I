using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Lineales
{
    public class Nodo<T>
    {
        //Atributos
        public Nodo<T> Siguiente { get; set; }
        public Nodo<T> Anterior { get; set; }
        public T Valor { get; set; }

        //Constructor
        public Nodo(T Dato)
        {
            Anterior = null;
            Siguiente = null;
            Valor = Dato;
        }

        //public Nodo<T> Siguiente
        //{
        //    get { return Siguiente; }
        //    set { Siguiente = value; }
        //}
    }
}

