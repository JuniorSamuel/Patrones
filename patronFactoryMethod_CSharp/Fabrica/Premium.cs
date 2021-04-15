using System;

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