using System;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 

namespace Fabrica
{
    //Objetos a crear
    class Premium : Usuario
    {
        public Premium(){}

        public override void TipoUsuario()
        {
            Console.WriteLine("Usuario premium");
        }
    }
}