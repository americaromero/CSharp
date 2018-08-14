using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{



    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string medio;

           /* Animal Reptil = new Animal("Reptil",5);

            Reptil.comer("hierba");*/

            Console.WriteLine("Dime el nombre del animal:");
            nombre = Console.ReadLine();
            Console.WriteLine("Dime dónde respira:");
            medio = Console.ReadLine();

            Animal Reptil2 = new Animal(nombre, 5);

            Reptil2.comer("carne");

            Animal Hervíboro = new Animal(nombre, 3);

            Hervíboro.respirar(nombre, medio);
;


            Console.ReadKey();



        }
    }
}
