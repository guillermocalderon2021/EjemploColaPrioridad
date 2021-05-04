using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaPrioridad
{
    class PriorityQueuesProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n Demo colas de prioridad");

            Console.WriteLine("\nCreando cola de prioridad de empleados\n");
            PriorityQueue<Empleado> pq = new PriorityQueue<Empleado>();

            Empleado e1 = new Empleado("Juan", 1.0);
            Empleado e2 = new Empleado("Marcos", 2.0);
            Empleado e3 = new Empleado("Flor", 3.0);
            Empleado e4 = new Empleado("Ricardo", 4.0);
            Empleado e5 = new Empleado("Evelyn", 5.0);
            Empleado e6 = new Empleado("Diego", 6.0);

            Console.WriteLine("Agregando a " + e5.ToString() + " a la cola de prioridad");
            pq.Enqueue(e5);
            Console.WriteLine("Agregando a " + e3.ToString() + " a la cola de prioridad");
            pq.Enqueue(e3);
            Console.WriteLine("Agregando a " + e6.ToString() + " a la cola de prioridad");
            pq.Enqueue(e6);
            Console.WriteLine("Agregando a " + e4.ToString() + " a la cola de prioridad");
            pq.Enqueue(e4);
            Console.WriteLine("Agregando a " + e1.ToString() + " a la cola de prioridad");
            pq.Enqueue(e1);
            Console.WriteLine("Agregando a " + e2.ToString() + " a la cola de prioridad");
            pq.Enqueue(e2);

            Console.WriteLine("\nContenido de la cola de prioridad: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Eliminando un empleado de la cola de prioridad");
            Empleado e = pq.Dequeue();
            Console.WriteLine("El empleado eliminado es " + e.ToString());
            Console.WriteLine("\nEl contenido de la cola de prioridad es: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

            Console.WriteLine("Eliminando un segundo empleado de la cola de prioridad");
            e = pq.Dequeue();
            Console.WriteLine("\nLa cola de prioridad es ahora: ");
            Console.WriteLine(pq.ToString());
            Console.WriteLine("\n");

         
            Console.ReadLine();
        } // Main()

        

    } // class PriorityQueuesProgram

    

    
}
