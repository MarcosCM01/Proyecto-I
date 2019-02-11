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
        
        public void Eliminar (T valor)
        {
            if (Cabeza.siguiente != null)
            {
                Cabeza.siguiente = Cabeza;
                Cabeza.anterior = NULL;
            }
            else
            {
                //Indicar que la pila esta vacia
            }
        }
        
        public void Buscar(T valor)
        {
            Buscado = new Nodo<T>(valor);
            Recorrido = new Nodo<T>(valor);
            Recorrido = cabeza; //Este nodo sera el que sirva para recorrer la pila
            //Pedir al usuario que ingrese a quien buscara y almacenarlo en el nodo
            if (Cabeza.siguiente != null)
            {
                if (Buscado == Cabeza)
                {
                //Se encontro al que buscaba
                }
                else
                {
                    while (Recorrido.siguiente != Buscado)
                    {
                        //Moverlo de posicion en la pila
                    }
                }
            }
            else 
            {
                //Indicar que la lista esta vacia
            }
            
        }
    }
}

