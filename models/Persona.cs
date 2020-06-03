namespace firstApp.models
{
    public class Persona: Instituto
    {  public static int contadorPersona=0;
       
     
        public int id { get; set; }

        public string nombre { get; set; }
        public int edad { get; set; }
        public int tel { get; set; }

        public Persona(){
            contadorPersona++;
        }
        string Instituto.codigoInterno{
            get;
            set;
        }

        
        public string construirLlavesecreta(string nombreEnte){
         return "llave";
          
        }
    }
}