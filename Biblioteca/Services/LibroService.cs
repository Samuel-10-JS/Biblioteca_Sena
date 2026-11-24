using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Models;

namespace Biblioteca.Services
{
    public class LibroService
    {
        private List<Libro> libros = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            if (libro != null)
            {
                libros.Add(libro);
            }
        }

        public bool EliminarLibro(string id)
        {
            Libro libro = BuscarPorIdOIsbn(id);
            if (libro != null && libro.Disponible)
            {
                libros.Remove(libro);
                return true;
            }
            return false;
        }

        public List<Libro> ObtenerTodos()
        {
            return libros;
        }

        public Libro BuscarPorIdOIsbn(string id)
        {
            foreach (Libro l in libros)
            {
                if (l.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return l;
                }
            }
            return null;
        }

        public List<Libro> BuscarPorTituloOAutor(string criterio)
        {
            List<Libro> resultados = new List<Libro>();
            foreach (Libro l in libros)
            {
                if (l.Titulo.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                    l.Autor.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                    l.Categoria.Contains(criterio, StringComparison.OrdinalIgnoreCase))
                {
                    resultados.Add(l);
                }
            }
            return resultados;
        }

        public List<Libro> ObtenerDisponibles()
        {
            List<Libro> disponibles = new List<Libro>();
            foreach (Libro l in libros)
            {
                if (l.Disponible)
                {
                    disponibles.Add(l);
                }
            }
            return disponibles;
        }

        public List<Libro> ObtenerPrestados()
        {
            List<Libro> prestados = new List<Libro>();
            foreach (Libro l in libros)
            {
                if (!l.Disponible)
                {
                    prestados.Add(l);
                }
            }
            return prestados;
        }

        public List<Libro> OrdenarPorTitulo()
        {
            return libros.OrderBy(l => l.Titulo).ToList();
        }

        public List<Libro> OrdenarPorAnio()
        {
            return libros.OrderBy(l => l.Anio).ToList();
        }

        public int ObtenerTotalLibros()
        {
            return libros.Count;
        }

        public int ObtenerTotalDisponibles()
        {
            return ObtenerDisponibles().Count;
        }

        public int ObtenerTotalPrestados()
        {
            return ObtenerPrestados().Count;
        }
    }
}
