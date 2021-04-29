using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.Ejercicio2.Manejobasicodelistas
{
    class Program
    {

        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = {"RED","WHITE","BLUE"};

        static void Main(string[] args)
        {

            /*a.Armar dos listas, una con los valores del vector “colors” y otra con los valores del vector “removeColors”.*/
            List<string> listacolors = new List<string>();
            List<string> listaremovercolores = new List<string>();

            Console.WriteLine("a");
            for (int i = 0; i <= colors.Length - 1; i++)
            {
                listacolors.Add(colors[i]);
                

            }

            for (int i = 0; i <= removeColors.Length-1; i++)
            {
                listaremovercolores.Add(removeColors[i]);
                
            }


            /*b.Mostrar la lista de colores por pantalla.*/
            Console.WriteLine("b");
            Console.WriteLine("COLORES");

            foreach (string e in listacolors)
            {
                Console.Write(e + " ");
            }



            /*c.De la lista de colores eliminar los colores listados en la otra lista(removeColors).*/

            Console.WriteLine("c");
            for (int i = 0; i <= listaremovercolores.Count - 1 ; i++)
            {
                listacolors.Remove(listaremovercolores.ElementAt(i));
         
            }



            /*d.Volver a mostrar la lista de colores por pantalla.*/
            Console.WriteLine("d");
            Console.WriteLine("COLORES");

            foreach (string e in listacolors)
            {
                Console.Write(e+" ");
            }


            Console.ReadKey();
        }









    }

    }







