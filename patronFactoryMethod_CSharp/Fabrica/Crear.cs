
namespace Fabrica
{
    
    //Esta clase creara el objetos que solicitemos
    class Crear
    {
        //Estos atributos staticos funcionara como selector
        public static int basico = 1;
        public static int premium = 2;
        public static int admin = 3;

        //Este metodo seleccionara el objeto y lo retornara.
        public static Usuario getUsuario(int  i){
           switch (i)
           {
                case 1:
                    return new Basico();
                case 2: 
                    return new Premium();
                case 3:
                    return new Adimn();          
               default:
                    return null;
           }
       }

    }
}