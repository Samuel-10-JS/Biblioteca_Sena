namespace Biblioteca.Models
{
    public class Usuario
    {
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool Activo { get; set; }

        public Usuario()
        {
            Documento = "";
            Nombre = "";
            Email = "";
            Telefono = "";
            Activo = true;
        }

        public Usuario(string documento, string nombre, string email, string telefono)
        {
            Documento = documento;
            Nombre = nombre;
            Email = email;
            Telefono = telefono;
            Activo = true;
        }

        public string ResumenCorto()
        {
            return $"Usuario: {Nombre} - Doc: {Documento} (Activo: {Activo})";
        }

        public string DetalleCompleto()
        {
            return $"Documento: {Documento} | Nombre: {Nombre} | Email: {Email} | Teléfono: {Telefono} | Activo: {Activo}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
