using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaListas2
{
    public class NodoLista
    {
        
       
            private object dato;
            private NodoLista siguiente;

            //constructor para último Nodo:
            public NodoLista(object valorDato)
            {
                dato = valorDato;
                siguiente = null;
            }
            // constructor para otros nodos
            public NodoLista(object valorDato, NodoLista siguienteNodo)
            {
                dato = valorDato;
                siguiente = siguienteNodo;
            }

            //propiedades
            public NodoLista Siguiente
            {
                get { return siguiente; }
                set { siguiente = value; }
            }
            public object Dato
            {
                get { return dato; }
            }
        }// Fin de NodoLista

    
}
