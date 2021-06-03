using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace practica
{

    class Program
    {
        
        static void Main(string[] args)
        {
            int vec = 0;
            int suma = 0;
            int resta = 0;
            int cont = 0;
            int promedio = 0;
            do
            {
                cont++;
                Console.WriteLine("ingrese num");

                vec = int.Parse(Console.ReadLine());

                Task<int> t0 = new Task<int>((arg) => {

                    int localresta = (int)arg;
                    localresta -= vec;
                    return localresta;
                }, resta);

                t0.Start();
                t0.Wait();

                resta = t0.Result;

                Task<int> t1 = new Task<int>((arg) => {

                    int localsuma = (int)arg;
                    localsuma += vec;
                    return localsuma;
                }, suma);

                t1.Start();
                suma = t1.Result;

                Task<int> t2 = t1.ContinueWith((predecesor) =>
                  {
                      int localsuma = predecesor.Result;
                      int localpromedio = localsuma / cont;
                      return localpromedio;

                  });

                t2.Wait();
                promedio = t2.Result;


                Task.WaitAll(new Task[] { t0,t1,t2 });

            

            } while (vec != 0);


            Console.WriteLine("la resta es {0} la suma es{1} el promedio es{2} ", resta , suma , promedio);







        }
    }
}
