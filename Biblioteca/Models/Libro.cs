namespace Biblioteca.Models
{
    public class Libro
    {
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Anio { get; set; }
        public string Categoria { get; set; }
        public bool Disponible { get; set; }

        public Libro()
        {
            Id = "";
            Titulo = "";
            Autor = "";
            Anio = 2026;
            Categoria = "";
            Disponible = true;
        }

        public Libro(string id, string titulo, string autor, int anio, string categoria)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Anio = anio;
            Categoria = categoria;
            Disponible = true;
        }

        public string ResumenCorto()
        {
            return $"Libro: {Titulo} - Autor: {Autor} (Disponible: {Disponible})";
        }

        public string DetalleCompleto()
        {
            return $"ID: {Id} | Título: {Titulo} | Autor: {Autor} | Año: {Anio} | Categoría: {Categoria} | Disponible: {Disponible}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
