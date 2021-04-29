using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase3.Ejercicio4.Netflix
{
    class Program
    {
        

        static void Main(string[] args)
        {

          
           // string[] lines = File.ReadAllLines("./File/ratings.txt");
            // Console.WriteLine(String.Join(Environment.NewLine, lines));

            StreamReader lectura;
            string cadena;

            bool encontrado=false;

            string[] campos = new string[4];

            char[] separador = { ',' };

            try
            {
                lectura = File.OpenText("./File/ratings.txt");

                cadena = lectura.ReadLine();

                while(cadena!=null && encontrado== false )
                {
                    campos = cadena.Split(separador);

                    

                }
            }
            catch(FileNotFoundException fe)
            {
                Console.WriteLine("!ERROR¡" + fe.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("!ERROR¡" + e.Message);
            }
        }
    }
}
