namespace Listas
{
     public class Tareas
    {
        private int TareaID;
        private string Descripcion;

        private int Duracion;

        public Tareas()
        {
        }

        public Tareas(int tareaID, string descripcion, int duracion)
        {
            this.TareaID = tareaID;
            this.Descripcion = descripcion;
            this.Duracion = duracion;
            
        }

        public int TareaID1 { get => TareaID; set => TareaID = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int Duracion1 { get => Duracion; set => Duracion = value; }
        public void Mostrar(){
            Console.WriteLine("ID de tarea {0}", this.TareaID);
            Console.WriteLine("Descripcion de tarea {0}", this.Descripcion);
            Console.WriteLine("La duracion es {0}", this.Duracion);
            
            
        }

        
    }  
}