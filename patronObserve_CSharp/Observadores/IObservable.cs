using System;

namespace Observadores
{
        //Interfaz para implementar en los observados

    public interface IObservable
    {
        void Agregar(IObservador Objeto);
        void eliminar(IObservador Objeto);
        void Notificar();
    }
}