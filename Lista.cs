using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaListas2
{
   public class Lista
    {
        private NodoLista primerNodo;
        private NodoLista ultimoNodo;
        private string nombre;

        //Constructor de la lista vacia
        public Lista(string NumLista)
        {
            nombre = NumLista;
            primerNodo = ultimoNodo = null;

        }
        //metodo para insertar elementos al inicio de la lista
        //1-.Preguntar si está vacía
        public bool EstaVacia()
        {
            return primerNodo == null;
        }

        public void InsertarAlFrente(object elemento)
        {

            if (EstaVacia() == true)
            {
                primerNodo = ultimoNodo = new NodoLista(elemento);
            }
            else
            {
                primerNodo = new NodoLista(elemento, primerNodo);
            }

        }
        public void InsertarAlFinal(object elemento)
        {
            if (EstaVacia() == true)
            {
                primerNodo = ultimoNodo = new NodoLista(elemento);
            }
            else
            {
                ultimoNodo = ultimoNodo.Siguiente = new NodoLista(elemento);
            }
        }

        public object EliminarDelFrente()
        {
            if (EstaVacia() == true)
            {
                //poner un throw new Exception ListaVacia(y que de un mensaje con esta excepcion)
                // y recuperar los datos:
            }
            object eliminarObjeto = primerNodo.Dato;
            if (primerNodo == ultimoNodo)
            {
                primerNodo = ultimoNodo = null;
            }
            else
            {
                primerNodo = primerNodo.Siguiente;
            }
            return eliminarObjeto;



        }

        public object EliminarDelFinal()
        {
            if (EstaVacia() == true)
            {  //lanzar la excepcion
            }
            object eliminarElemento = ultimoNodo.Dato;
            if (primerNodo == ultimoNodo)
            {
                primerNodo = ultimoNodo = null;
            }
            else
            {
                //creo un auxiliar para recorrer la lista y llegar al final
                NodoLista actual = primerNodo;
                while (actual.Siguiente != ultimoNodo)
                {
                    actual = actual.Siguiente;
                }
                ultimoNodo = actual;
                actual.Siguiente = null;
            }
            return eliminarElemento;

        }

        //metodo para imprimir

        public string ImprimirLista()
        {
            string cadena = "";
            if (EstaVacia() == true)
            {
                cadena = "La lista" + nombre + "está vacía";
            }
            else
            {
                cadena = "La lista" + nombre + "es:\n";
                NodoLista actual = primerNodo;
                string cadenaDato;
                while (actual != null)
                {
                    cadenaDato = Convert.ToString(actual);
                    cadena = cadena + cadenaDato;
                    actual = actual.Siguiente;
                }
            }
            return cadena;
        }
    }
}

