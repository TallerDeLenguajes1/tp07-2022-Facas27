using System;

namespace Listas
{
    class Program
    {
        
    
    
    
        static void Main(string[] args)
        {
            List<Tareas>Tareas  = new List<Tareas>();
            Console.WriteLine("Ingrese la cantidad de tareas a cargas");
            int CantT = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < CantT; i++)
            {
               int id = i+1;
               Console.WriteLine("Ingrese la descrpcion de la tarea");
               string desc;
               desc = Console.ReadLine();
               Console.WriteLine("Ingrese la duracion de la tarea");
               int duracion = int.Parse(Console.ReadLine());
               Tareas p = new Tareas(id,desc,duracion);
               Tareas.Add(p);

                
                
            }
            List<Tareas>TareasCompletas = new List<Tareas>();
            List<Tareas>TareasIncompletas = new List<Tareas>();
            int cantHoras=0;
            foreach (Tareas item in Tareas)
            {
                Console.WriteLine("Mostrando Tareas");
                item.Mostrar();
                Console.WriteLine("La tarea esta finalizada? 1 = Si / 0 = NO");
                int opc = Convert.ToInt32(Console.ReadLine());
                if (opc == 1 )
                {
                    TareasCompletas.Add(item);
                }else
                {
                    TareasIncompletas.Add(item);
                }

                
            }
            Console.WriteLine("Las tareas realizadas son");
            foreach (Tareas item in TareasCompletas)
            {
                item.Mostrar();
                cantHoras += item.Duracion1;
            }
            Console.WriteLine("Las tareas NO realizadas son");
            foreach (Tareas item in TareasIncompletas)
            {
                item.Mostrar();
            }
            Console.WriteLine("La cantidad de horas trabajadas es : {0}", cantHoras);







        }
       } 
   
    
}

   