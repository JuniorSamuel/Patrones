using System;
using patronObserve_CSharp;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 

namespace Observadores
{
    //Interfaz para implementar en los observadores
    public interface IObservador{
        void Actualizacion(String nombreTarea);
    }
}