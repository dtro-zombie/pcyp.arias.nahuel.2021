/* Program.cs */

//
// Sequential C# Version
//
// Sequentially processes a text file of movie reviews, one per line, 
// the format of which are:
//
//   movie id, user id, rating (1..5), date (YYYY-MM-DD)
//
// The output are the top 10 users who reviewed the most movies, in 
// descending order (so the user with the most reviews is listed 
// first).
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Threading;

namespace top10
{
    class Program
    {



        // un diccionario para ir guardando el id y las veces que voto 
        static Dictionary<int, int> ReviewsByUser = new Dictionary<int, int>();



        static void Main(string[] args)


        {

            // esto es un cronometro
            var sw = System.Diagnostics.Stopwatch.StartNew();

            
            // para obtener la dirreccion del archivo
            string infile = AppDomain.CurrentDomain.BaseDirectory + @"\..\..\..\ratings.txt";

        
            //reinicia el cronometro
            sw.Restart();



            


            //aca estaria el map
            //  se va hacer un forech con los parametros contenidos por infile en la direccion que guarda
            Parallel.ForEach(File.ReadLines(infile),

            
                // donde incia ()=>    y lo que retorna en este caso un diccionario
               () => { return new Dictionary<int, int>(); }, 

               // line= el que recorre loopcontrol= el index de donde se encuetra en el foreach  localID= el retorno que luego se cocecha ( el diccionaryo ) 
             (line, loopControl, localD) =>
             {

                 // se usa userid para guardar la id del usuario que es eviada por parse, que recibe como parametro una linea del diccionario( archivo )
                 int userid = parse(line);

                 //se pregunta si no existe la id y  se la agrega
                 if (!localD.ContainsKey(userid))  
                     localD.Add(userid, 1);

                 //pero si esta sole se le agraga uno mas
                 else  
                     localD[userid]++;


                 // se  retorna la id
                 return localD;  
             },



             // aca seria el reduce
             //aca es donde se produce la coceha de los datos
              (localD) =>
              {

                  // como ReviewsByUser es la zona crtica donde las tareas van a escribir se usa el lock para controlar
                  lock (ReviewsByUser)
                  {
                      // se escribe ReviewsByUser con los datos cocechados LocalID
                      foreach (int userid in localD.Keys)
                      {
                          int numreviews = localD[userid];

                          if (!ReviewsByUser.ContainsKey(userid))  
                              ReviewsByUser.Add(userid, numreviews);
                          else  
                              ReviewsByUser[userid] += numreviews;
                      }
                  }
              }

            );


            //se ordena desendiente y se toma los diez primeros
            var top10 = ReviewsByUser.OrderByDescending(x => x.Value).Take(10);

            long timems = sw.ElapsedMilliseconds;

            //todo para porder imprimir
            Console.WriteLine();
            Console.WriteLine("** Top 10 users reviewing movies:");

            foreach (var user in top10)
                Console.WriteLine("{0}: {1}", user.Key, user.Value);

            
            double time = timems / 1000.0;  

            Console.WriteLine();
            Console.WriteLine("** Done! Time: {0:0.000} secs", time);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Press a key to exit...");
            Console.ReadKey();
        }


        
        private static int parse(string line)
        {

            // se usa la coma para separar los datos del archivo
            char[] separators = { ',' };
            //  se utiliza un array tokens para guardar los datos separados por la coma
            string[] tokens = line.Split(separators);
            // se utilizan diferentes variables para contener de forma individual los datos en tokens 
            int movieid = Convert.ToInt32(tokens[0]);
            int userid = Convert.ToInt32(tokens[1]);
            int rating = Convert.ToInt32(tokens[2]);
            DateTime date = Convert.ToDateTime(tokens[3]);

            // solo retorna el user id que se usa mas arriba 
            return userid;
        }

    }//class
}//namespace
