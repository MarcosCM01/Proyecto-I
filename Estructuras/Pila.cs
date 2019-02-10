using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Lineales 
{
    class Pila<T> : IEstructurasLineales<T> //Heredando la Interfaz de estructuras lineales (agregar, eliminar, buscar)
    {
        //Atributos de Pila
        static Nodo<T> Cabeza { get; set; } //Donde salen y entran los elementos
        static int Tamaño { get; set; }

        public void Agregar(T Valor)
        {
            //Agrega si no hay nada en la pila
            if (Tamaño == 0)
            {
                Cabeza = new Nodo<T>(Valor);
                Cabeza.Valor = Valor;
                Tamaño++;
            }
           else //De lo contrario, el nuevo se convierte en la cabeza
           {
               Nuevo = new Nodo<T>(valor);
               Nuevo.siguiente = Cabeza;
               Cabeza.anterior = Nuevo;
               Cabeza = Nuevo;
           } 
        }
    }
}

