using System;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 

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