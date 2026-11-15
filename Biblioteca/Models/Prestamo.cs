using System;

namespace Biblioteca.Models
{
    public class Prestamo
    {
        public string Id { get; set; }
        public Libro LibroPrestado { get; set; }
        public Usuario UsuarioPrestamo { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime? FechaDevolucion { get; set; }
        public EstadoPrestamo Estado { get; set; }

        public Prestamo()
        {
            Id = "";
            LibroPrestado = new Libro();
            UsuarioPrestamo = new Usuario();
            FechaPrestamo = DateTime.Now;
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
        }

        public Prestamo(string id, Libro libro, Usuario usuario, DateTime fechaPrestamo)
        {
            Id = id;
            LibroPrestado = libro;
            UsuarioPrestamo = usuario;
            FechaPrestamo = fechaPrestamo;
            FechaDevolucion = null;
            Estado = EstadoPrestamo.Activo;
        }

        public bool EstaVencido()
        {
            if (Estado == EstadoPrestamo.Activo)
            {
                return DateTime.Now > FechaPrestamo.AddDays(7);
            }
            return false;
        }

        public int DiasTranscurridos()
        {
            DateTime fechaFin = FechaDevolucion ?? DateTime.Now;
            TimeSpan diferencia = fechaFin - FechaPrestamo;
            return diferencia.Days;
        }

        public string ResumenCorto()
        {
            return $"Préstamo #{Id} - Libro: {LibroPrestado.Titulo} - Usuario: {UsuarioPrestamo.Nombre} [Estado: {Estado}]";
        }

        public string DetalleCompleto()
        {
            string fechaDevStr = FechaDevolucion.HasValue ? FechaDevolucion.Value.ToString("yyyy-MM-dd") : "Pendiente";
            return $"ID Préstamo: {Id} | Libro: {LibroPrestado.Titulo} | Usuario: {UsuarioPrestamo.Nombre} | Fecha: {FechaPrestamo:yyyy-MM-dd} | Devolución: {fechaDevStr} | Estado: {Estado} | Vencido: {EstaVencido()} | Días: {DiasTranscurridos()}";
        }

        public override string ToString()
        {
            return ResumenCorto();
        }
    }
}
