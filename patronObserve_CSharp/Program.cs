using System;
using Observadores;
using Observados;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 
namespace patronObserve_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos a los objetos que tomaran el papel de observador
            EstudianteA estA = new EstudianteA();
            EstudianteB estB = new EstudianteB();

            //Creamos el objetos observado
            PublicarTarea pt = new PublicarTarea();

            //agregamos los observadores
            pt.Agregar(estA); 
            pt.Agregar(estB);

            //Publicamos una nueva tarea
            pt.NuevaTarea("Ejercicio Patrones de diseño");

            //Salida de la consola
            //#  Estudiante A, Actualizado; Nueva tarea: Ejercicio Patrones de diseño
            //#  Estudiante B, Actualizado; Nueva tarea: Ejercicio Patrones de diseño
            
            Console.WriteLine(""); //Esta linea solo es para separa la informacion en la consola.
        
            //Ahora eliminaremos un objeto de la lista de observadores
            pt.eliminar(estA);

            //Creamos una nueva publicacion
            pt.NuevaTarea("Investiga");

            //Salida de la consola
            //#  Estudiante B, Actualizado; Nueva tarea: Investiga
        }
    }
}
