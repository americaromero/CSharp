using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Animal
    {
        public string especie, clase, familia, genero;
        public float tamano;

        public Animal(string espe, float tam)
        {
            especie = espe;
            tamano = tam;

        }

        public Animal(string espe, float tam, string cla, string fam, string genre)
        {
            especie = espe;
            tamano = tam;
            clase = cla;
            familia = fam;
            genero = genre;
     
        }

        public void comer(string comida)
        {
            Console.WriteLine("El animal de nombre" + " "+ especie + " está comiendo " +  comida);
        }


        public void respirar( string nombre, string medio)
        {

            Console.WriteLine(nombre + " respira en el " + medio );
        }



  
       ////Encapsulamineto CS
       //modificadore de acceso


        //comer

       //respirar

       //reproducen


    }
}
