using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploColaPrioridad
{
    public class PriorityQueue<T> where T : IComparable<T>
    {
        private List<T> data;

        public PriorityQueue()
        {
            this.data = new List<T>();
        }

        public void Enqueue(T item)
        {
            data.Add(item);
            int ci = data.Count - 1; // posicion que ocupa el nuevo nodo en el arreglo
            while (ci > 0)
            {
                int pi = (ci - 1) / 2; // Indice del padre
                if (data[ci].CompareTo(data[pi]) >= 0) break; //La prioridad del hijo es mayor o igual a la del padre. No hay nada que hacer
                // Haciendo la sustitucion de valores
                T tmp = data[ci];
                data[ci] = data[pi];
                data[pi] = tmp;
                ci = pi;
            }
        }

        public T Dequeue()
        {
            
            int li = data.Count - 1; // Ultimo indice antes de borrar
            T frontItem = data[0];   // Tomamos el primer valor
            data[0] = data[li]; //Colocamos el ultimo elemento en la primera posicion
            data.RemoveAt(li); //Quitamos el nodo de la lista

            --li; // Ultimo indice despues de borrar
            int pi = 0; // Indice del padre. Inicia al frente de la cola de prioridad
            while (true)
            {
                int ci = pi * 2 + 1; // Indice del hijo izquierdo
                if (ci > li) break;  // Si no hay hijo izquierdo
                int rc = ci + 1;     // Indice del hijo derecho
                if (rc <= li && data[rc].CompareTo(data[ci]) < 0) // si hay un hijo derecho y es menor que el hijo izquierdo, use el derecho en su lugar
                    ci = rc;
                if (data[pi].CompareTo(data[ci]) <= 0) break; //El padre es menor o igualque el menor de los hijos
                // Intercambiar padre e hijo
                T tmp = data[pi];
                data[pi] = data[ci];
                data[ci] = tmp; 
                pi = ci;
            }
            return frontItem;
        }

        public T Peek()
        {
            T frontItem = data[0];
            return frontItem;
        }

        public int Count()
        {
            return data.Count;
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < data.Count; ++i)
                s += data[i].ToString() + " ";
            s += "count = " + data.Count;
            return s;
        }

        
    } // PriorityQueue
}
