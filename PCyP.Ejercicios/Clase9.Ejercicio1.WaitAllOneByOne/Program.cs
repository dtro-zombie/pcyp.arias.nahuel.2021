using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Clase9.Ejercicio1.WaitAllOneByOne
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            //lista de tareas
            Task<int>[] tasks = new Task<int>[3];
            //Ejecutar tarea
            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });
            //mientras el largo de las tareas sea mayor a 0
            while (tasks.Length > 0)
            {
                //guarda la tarea que termina primero en i
                int i = Task.WaitAny(tasks);
                //la tarea completada la guardo en un  variable task
                Task<int> completedTask = tasks[i];
                //el resultado de la task lo sumo en sum
                Console.WriteLine(sum+=completedTask.Result);
                //hago un arrary temporal que copia atask
                var temp = tasks.ToList();
                //remuevo la task del del indice i
                temp.RemoveAt(i);
                //igualo task con la array temporal
                tasks = temp.ToArray();
            }
            Console.ReadLine();
        }
    }
}