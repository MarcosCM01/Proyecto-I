using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estructura_de_Datos__Proyecto_I.Helpers__Singleton_
{
    public class Datos
    {
        private static Datos instancia = null;

        public static Datos ObteniendoInstancia
        {
            get
            {
                //Si no se ha creado la instancia -> se crea y se retorna
                //Si ya esta creada la instancia -> solo se devuelve
                if(instancia == null)
                {
                    instancia = new Datos();
                }
                return instancia;
            }
        }
    }
}
