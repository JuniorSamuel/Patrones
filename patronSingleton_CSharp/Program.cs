using System;

namespace patronSingleton_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creamos el primer objeto de la clase Hoja 
            Hoja hoja1 = Hoja.getHoja();            
            hoja1.agregar("Primera linea objetos hoja1");
            Console.WriteLine(hoja1.getNotas());  //Imprimira: "Primera linea objetos hoja1"

            //Creamos un segundo objetos, que enrealizada en el mismo que Hoja1
            Hoja hoja2 = Hoja.getHoja();
            Console.WriteLine(hoja2.getNotas()); //AL ser el mismo objetos imprimira: "Primera linea objetos hoja1"
        }
    }
}
