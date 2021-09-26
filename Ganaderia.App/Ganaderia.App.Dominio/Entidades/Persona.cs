namespace Ganaderia.App.Dominio
{
    /// Clase Persona
    public class Persona  
    {
        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }  
        public string NumeroTelefono { get; set; }
        public string Direccion { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}