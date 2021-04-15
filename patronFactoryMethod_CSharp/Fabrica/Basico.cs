using System;

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