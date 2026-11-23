using System;
using System.Collections.Generic;
using System.Linq;
using Biblioteca.Models;

namespace Biblioteca.Services
{
    public class PrestamoService
    {
        private List<Prestamo> prestamos = new List<Prestamo>();

        public void AgregarPrestamo(Prestamo prestamo)
        {
            if (prestamo != null)
            {
                prestamos.Add(prestamo);
            }
        }

        public bool EliminarPrestamo(string id)
        {
            Prestamo p = BuscarPorId(id);
            if (p != null)
            {
                prestamos.Remove(p);
                return true;
            }
            return false;
        }

        public List<Prestamo> ObtenerTodos()
        {
            return prestamos;
        }

        public Prestamo BuscarPorId(string id)
        {
            foreach (Prestamo p in prestamos)
            {
                if (p.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return p;
                }
            }
            return null;
        }

        public List<Prestamo> BuscarPorEstado(EstadoPrestamo estado)
        {
            List<Prestamo> resultados = new List<Prestamo>();
            foreach (Prestamo p in prestamos)
            {
                if (p.Estado == estado)
                {
                    resultados.Add(p);
                }
            }
            return resultados;
        }

        public List<Prestamo> ObtenerActivos()
        {
            return BuscarPorEstado(EstadoPrestamo.Activo);
        }

        public List<Prestamo> ObtenerDevueltos()
        {
            return BuscarPorEstado(EstadoPrestamo.Devuelto);
        }

        public List<Prestamo> ObtenerVencidos()
        {
            List<Prestamo> vencidos = new List<Prestamo>();
            foreach (Prestamo p in prestamos)
            {
                if (p.EstaVencido() || p.Estado == EstadoPrestamo.Vencido)
                {
                    vencidos.Add(p);
                }
            }
            return vencidos;
        }

        public List<Prestamo> OrdenarPorFecha()
        {
            return prestamos.OrderBy(p => p.FechaPrestamo).ToList();
        }

        public int ObtenerTotalPrestamos()
        {
            return prestamos.Count;
        }

        public int ObtenerTotalActivos()
        {
            return ObtenerActivos().Count;
        }

        public int ObtenerTotalDevueltos()
        {
            return ObtenerDevueltos().Count;
        }

        public int ObtenerTotalVencidos()
        {
            return ObtenerVencidos().Count;
        }

        public double ObtenerPromedioDiasPrestamo()
        {
            if (prestamos.Count == 0)
            {
                return 0.0;
            }

            int sumaDias = 0;
            foreach (Prestamo p in prestamos)
            {
                sumaDias += p.DiasTranscurridos();
            }
            return (double)sumaDias / prestamos.Count;
        }
    }
}
