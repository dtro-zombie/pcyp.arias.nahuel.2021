using System;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            Task<int> t1 = Task<int>.Factory.StartNew((arg) => {
                int sumaT = (int)arg + 10;
                return sumaT;
            }, suma);
            Task<int> t2 = Task.Factory.StartNew((arg) => {
                int sumaT = (int)arg + 10;
                return sumaT;
            }, suma);

            int cantidadTareas = 2;
            Task[] tasks = new Task[] { t1, t2 };
            int indice;
            while (cantidadTareas > 0)
            {
                indice = Task.WaitAny(tasks);
                cantidadTareas--;
                suma += tasks[indice].Result;
            }

            Console.WriteLine(suma);
        }
    }
}
