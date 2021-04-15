using System;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 

namespace Observadores
{
    //Los observadores debe implementar la interfaz IObservador.
    class EstudianteA : IObservador  //Este Objetos sera un observador
    {
        //Este metodo sera llamado cada vez que tengamos una nueva publicacion
        public void Actualizacion(string ultimaTarea) 
        {
            Console.WriteLine("Estudiante A, Actualizado; Nueva tarea: "+ ultimaTarea);
        }
    }
}