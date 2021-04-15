using System;
using patronObserve_CSharp;

namespace Observadores
{
    //Interfaz para implementar en los observadores
    public interface IObservador{
        void Actualizacion(String nombreTarea);
    }
}