using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Models;

namespace Biblioteca.Services
{
    public class UsuarioService
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void AgregarUsuario(Usuario usuario)
        {
            if (usuario != null)
            {
                usuarios.Add(usuario);
            }
        }

        public bool EliminarUsuario(string documento)
        {
            Usuario u = BuscarPorDocumento(documento);
            if (u != null)
            {
                usuarios.Remove(u);
                return true;
            }
            return false;
        }

        public List<Usuario> ObtenerTodos()
        {
            return usuarios;
        }

        public Usuario BuscarPorDocumento(string documento)
        {
            foreach (Usuario u in usuarios)
            {
                if (u.Documento.Equals(documento, StringComparison.OrdinalIgnoreCase))
                {
                    return u;
                }
            }
            return null;
        }

        public List<Usuario> BuscarPorNombre(string criterio)
        {
            List<Usuario> resultados = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (u.Nombre.Contains(criterio, StringComparison.OrdinalIgnoreCase) ||
                    u.Documento.Contains(criterio, StringComparison.OrdinalIgnoreCase))
                {
                    resultados.Add(u);
                }
            }
            return resultados;
        }

        public List<Usuario> ObtenerActivos()
        {
            List<Usuario> activos = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (u.Activo)
                {
                    activos.Add(u);
                }
            }
            return activos;
        }

        public List<Usuario> ObtenerInactivos()
        {
            List<Usuario> inactivos = new List<Usuario>();
            foreach (Usuario u in usuarios)
            {
                if (!u.Activo)
                {
                    inactivos.Add(u);
                }
            }
            return inactivos;
        }

        public List<Usuario> OrdenarPorNombre()
        {
            return usuarios.OrderBy(u => u.Nombre).ToList();
        }

        public int ObtenerTotalUsuarios()
        {
            return usuarios.Count;
        }

        public int ObtenerTotalActivos()
        {
            return ObtenerActivos().Count;
        }

        public int ObtenerTotalInactivos()
        {
            return ObtenerInactivos().Count;
        }
    }
}
