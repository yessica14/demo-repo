namespace firstApp.models
{
    public interface Instituto
    {
        string codigoInterno { get; set; }

        string construirLlavesecreta(string nombre);
    }
}