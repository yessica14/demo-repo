namespace firstApp.models

{
    public class salon : Instituto
    {
        public int id { get; set; }
        public string nombre { get; set; }

        public string codigoInterno{
            get;
            set;
        }

        public string construirLlavesecreta(string nombre){
            return "hola";
        }

        
    }
}