using Fabrica;

//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 
namespace patronFactoryMethod_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crearemos un Usuario basico
            Usuario sB = Crear.getUsuario(Crear.basico);
            sB.TipoUsuario(); //Salida en consola: Usuario basico

            //Crearemos un Usuario primium
            Usuario sP = Crear.getUsuario(Crear.premium);
            sP.TipoUsuario(); //Salida en consola: Usuario premium

            //Crearemos un Usuario administrador
            Usuario sA = Crear.getUsuario(Crear.admin);
            sA.TipoUsuario(); //Salida en consola: Usuario Administrador
        }
    }
}
