using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clsae3.Ejercicio1.Manejobasicodediccionario
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Implementar un diccionario que contendrá los siguientes valores:
values.Add("Juan", "55423412");
values.Add("Ernesto", "56985623");
values.Add("Mariana", "54787451");
Realice las siguientes operaciones:
a. Revisar en el diccionario si existe un índice llamado “Juan”. En caso de que exista,
mostrar su valor (utilice el método ContainsKey)





*/



            Dictionary<string, string> values = new Dictionary<string, string>();
            values.Add( "Juan", "55423412");
            values.Add("Ernesto", "56985623");
            values.Add("Mariana", "54787451");

          


if(values.ContainsKey("Juan"));
            {
                Console.WriteLine(values["Juan"]);
            }


            /*
             * b. Revisar en el diccionario si existe un índice llamado “Pedro”. En caso de que exista,
               mostrar su valor, si no existe imprimir por pantalla “No contiene la llave” (utilice el
               método TryGetValue)
             */

            string value;
            if (values.TryGetValue("Pedro", out value))
            {
                Console.WriteLine("For key = \"Pedro\", value = {0}.", value);
            }
            else
            {
                Console.WriteLine("No contiene la llave");
            }

            /*c.Recorrer el diccionario y mostrar todos sus datos (índice y valor).*/

            foreach (KeyValuePair<string, string> element in values)
            {
                Console.WriteLine("Key = {0}  numero = {1}", element.Key, element.Value);

            }

            /*d.Alterar el valor cuyo índice es “Mariana” por “58251425”. Imprimir el nuevo valor.*/




            values.Remove("Mariana");
            values.Add("Mariana","58251425");


            foreach (KeyValuePair<string, string> element in values)
            {

                if (element.Key == "Mariana")
                {
                    Console.WriteLine("Key = {0}  numero = {1}", element.Key, element.Value);
                }
            }


            Console.ReadKey();
        }
    }
}
