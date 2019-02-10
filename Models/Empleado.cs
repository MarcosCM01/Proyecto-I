using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Estructura_de_Datos__Proyecto_I.Models
{
    //Datos de empleado
    public class Empleado
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public DateTime TiempoEntrada{ get; set; }
        public DateTime TiempoSalida { get; set; }
        public Random Citas { get; set; } //Entre 1 y 4 citas se tendrán que generar
        public int TotalHorasTrabajadas { get; set; } //Cada cita dura 1.5 horas + 2 horas trabajadas obteniendo citas
        public bool EnOficina { get; set; } 
        public double Sueldo { get; set; } //horas trabajadas * Q. 38

    }
}
