using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaPrioridad
{
    public class Empleado : IComparable<Empleado>
    {
        public string nombre;
        public double prioridad; // smaller values are higher priority

        public Empleado(string nombre, double prioridad)
        {
            this.nombre = nombre;
            this.prioridad = prioridad;
        }

        public override string ToString()
        {
            return "(" + nombre + ", " + prioridad.ToString("F1") + ")";
        }

        public int CompareTo(Empleado other)
        {
            if (this.prioridad < other.prioridad) return -1;
            else if (this.prioridad > other.prioridad) return 1;
            else return 0;
        }
    } 
}
