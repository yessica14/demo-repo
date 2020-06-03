namespace firstApp.models


{
    public class Alumno:Persona
    {   
      enum EstadoAlumno{
    matriculado,
    activo,
    suspendido,
    expulsado,
    egresado,
    retirado
    
}
       
       public string email { get; set; }
    }
}