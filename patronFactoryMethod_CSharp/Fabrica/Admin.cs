using System;

namespace Fabrica
{
    //Objetos a crear
    class Adimn : Usuario
    {
        public Adimn(){}

        public override void TipoUsuario()
        {
            Console.WriteLine("Usuario Administrador");
        }
    }
}