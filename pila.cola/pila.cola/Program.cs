using PilA.ColA.tads.pc;
using System;

namespace PilA.ColA
{
    class Program
    {
        static void Main(string[] args)
        {

            pila valorpila = new pila();


            Console.WriteLine("....su PILA es.....");
            valorpila.Añadir(5);
            valorpila.Añadir(10);
            valorpila.Añadir(8);
            valorpila.EliminarData();
            valorpila.Añadir(4);

            for (int i = 2; i > -1; i--)
            {
                Console.WriteLine(valorpila.DATAP[i]);

            }
            Console.WriteLine("......................");
            Console.WriteLine();
            Console.WriteLine("....su COLA es.....");
            cola valorcola = new cola();
            valorcola.AÑadirdato(6);
            valorcola.AÑadirdato(9);
            valorcola.AÑadirdato(4);
            valorcola.ELIMINARDATO();
            valorcola.AÑadirdato(65);


            for (int i = valorcola.ULTIMO; i > valorcola.PRIMERO; i--)

            {
                Console.WriteLine(valorcola.DATO[i]);

            }
            Console.WriteLine("......................");

            Console.ReadKey();

        }
    }
}
