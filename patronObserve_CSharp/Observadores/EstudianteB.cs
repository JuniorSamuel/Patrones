using System;

namespace Observadores
{
    //Los observadores debe implementar la interfaz IObservador.
    class EstudianteB : IObservador//Este Objetos sera un observador
    {
        //Este metodo sera llamado cada vez que tengamos una nueva publicacion
        public void Actualizacion(string ultimaTarea)
        {
            Console.WriteLine("Estudiante B, Actualizado; Nueva tarea: "+ ultimaTarea);
        }
    }
}