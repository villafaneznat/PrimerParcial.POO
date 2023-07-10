using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerParcial.POO.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*---------- CONO ----------*/
            //Creo el objeto
            Cono cono = new Cono(15, 10);

            //Muestro sus atributos
            Console.WriteLine(cono.ToString());


            /*---------- YARDAS, KM Y MILLAS ----------*/

            //Construyo los objetos

            Kilometros kilometros1 = new Kilometros(500);
            Kilometros kilometros2 = new Kilometros(1000);

            Yardas yardas1 = new Yardas(500);
            Yardas yardas2 = new Yardas(2000);

            Millas millas1 = new Millas(2220);
            Millas millas2 = new Millas(3003);

            //Muestro sus atributos

            Console.WriteLine($"{kilometros1.GetDistancia()}");
            Console.WriteLine($"{kilometros2.GetDistancia()}");
            Console.WriteLine($"{yardas1.GetDistancia()}");
            Console.WriteLine($"{yardas2.GetDistancia()}");
            Console.WriteLine($"{millas1.GetDistancia()}");
            Console.WriteLine($"{millas2.GetDistancia()}");

            //SOBRECARGA IMPLICTA
            float distancia = kilometros1;
            Console.WriteLine(distancia);

            Kilometros kilometros3 = distancia;
            Console.WriteLine(kilometros3.GetDistancia());

            //SOBRECARGA EXPLICITA

            Yardas yardas3 = (Yardas)kilometros1;
            Kilometros kilometros4 = (Kilometros)millas2;
            Millas millas3 = (Millas)kilometros4;

            //OPERACIONES

            var kilometrosEnCero = new Kilometros(0); //Para validar la division

            var suma = kilometros1 + kilometros2;
            var resta = kilometros1 - kilometros2;
            var multiplicacion = kilometros1 * kilometros2;
            var division = kilometrosEnCero != kilometros2 ? kilometrosEnCero //NO PUDE TERMINAR.
            Console.Write($"Suma entre kilometros1 y kilometros2: {suma.Distancia()}\n" +
                $"Resta entre kilometros1 y kilometros2: {resta.Distancia()}\n" +
                $"Multiplicacion entre kilometros1 y kilometros2: {multiplicacion.Distancia()}\n");
            if (division.Cantidad == 0)
            {
                Console.WriteLine("La cantidad de kilometros2 es cero, no puede divirse por cero.");
            }
            else
            {
                Console.WriteLine($"Division entre kilometros1 y kilometros2: {division.Distancia()}");
            }

            //LO ENTREGO PERO ME PRESENTO AL RECU.








        }
    }
}
