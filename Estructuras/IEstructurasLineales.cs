using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estructuras_Lineales
{
    //Interfaz de funciones y metodos a implementar
    interface IEstructurasLineales<T>
    {
        void Agregar(T Value);
        void Eliminar(T Value);
        void Encontrar(T Value);
    }
}
