using System;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 

namespace Fabrica
{
    //Objetos a crear
    class Basico : Usuario
    {
        public Basico(){}

        public override void TipoUsuario()
        {
            Console.WriteLine("Usuario basico");
        }
    }
}