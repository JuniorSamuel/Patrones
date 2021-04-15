using System;
using System.Collections.Generic;
using Observadores;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 
namespace Observados
{
    public class PublicarTarea : IObservable
    {   
        //Atribotos
        private List<IObservador> ListaObservadores =new List<IObservador>(); //Esta lista contendra a los observadores
        private string ultimaTarea; //Guardara el nombre de la ultima tarea

        //Constructor
        public PublicarTarea(){}

        //Este metodo agregara los observadores en la lista "ListaObservadores"
        public void Agregar(IObservador Objeto)
        {
            ListaObservadores.Add(Objeto);
        }

        //Este metodo eliminara los observadores en la lista "ListaObservadores"
        public void eliminar(IObservador Objeto)
        {
            ListaObservadores.Remove(Objeto);
        }

        //Este metodo se ejecutara cuando se agrege un nueva tarea y ejecutara 
        //el medoto Actualizacion() de los objetos almacenados en "ListaObservadores"
        public void Notificar() 
        {
            foreach (var ob in ListaObservadores)
            {
                ob.Actualizacion(ultimaTarea);
            }
        }

        //Este metodo capturada el nombre de la tarea y ejecutara el metodo Notificar()
        public void NuevaTarea(string nombreTarea){
            ultimaTarea = nombreTarea;
            Notificar();
        }
    }
}