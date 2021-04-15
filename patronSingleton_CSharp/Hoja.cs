
//Creado por Junior Samuel De Los Santos Velazquez
//matricula: 2019-8756 

namespace patronSingleton_CSharp
{
    class Hoja
    {
        //El primer y unico objeto de la clase se guardara 
        //en la variable variable hoja.
        private static Hoja hoja = null; 
        private string lineas = ""; 

        //El constructor debe ser privado para 
        //poder controlar los objetos que se crearan
        private Hoja(){ 

        }

        //Este metodo controlara que solo exista un objeto de la clase hoja         
        public static Hoja getHoja(){ 
            if (hoja == null)
            {
                hoja = new Hoja();                
            }
            return hoja;
        }

        public void agregar(string linea){
            lineas += linea+"\n";
        }

        public string getNotas(){
            return lineas;
        }
    }
}