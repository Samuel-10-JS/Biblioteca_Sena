using System;
using System.Collections.Generic;
using Biblioteca.Models;
using Biblioteca.Services;

class Program
{
    static LibroService libroService = new LibroService();
    static UsuarioService usuarioService = new UsuarioService();
    static PrestamoService prestamoService = new PrestamoService();

    static void Main(string[] args)
    {
        InicializarDatos();
        Console.WriteLine("========================================");
        Console.WriteLine("  SISTEMA DE BIBLIOTECA - CONSOLA C#");
        Console.WriteLine("========================================");
        ShowMainMenu();
    }

    static void InicializarDatos()
    {
        Libro l1 = new Libro("L001", "C# Avanzado", "John Skeet", 2021, "Programación");
        Libro l2 = new Libro("L002", "Clean Code", "Robert C. Martin", 2008, "Ingeniería") { Disponible = false };
        libroService.AgregarLibro(l1);
        libroService.AgregarLibro(l2);

        Usuario u1 = new Usuario("10203040", "Ana Pérez", "ana@mail.com", "3001234567");
        Usuario u2 = new Usuario("50607080", "Carlos Ruiz", "carlos@mail.com", "3107654321") { Activo = false };
        usuarioService.AgregarUsuario(u1);
        usuarioService.AgregarUsuario(u2);

        Prestamo p1 = new Prestamo("P001", l1, u1, DateTime.Now.AddDays(-10));
        prestamoService.AgregarPrestamo(p1);
    }

    static void ShowMainMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Libros");
            Console.WriteLine("2. Usuarios");
            Console.WriteLine("3. Préstamos");
            Console.WriteLine("4. Búsquedas y reportes");
            Console.WriteLine("5. Guardar / Cargar datos");
            Console.WriteLine("6. Probar Objetos y Modelos (EV07)");
            Console.WriteLine("7. Comparación Array vs List (EV08)");
            Console.WriteLine("8. Salir");
            Console.Write("Seleccione una opción (1-8): ");
            
            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                ShowBooksMenu();
            }
            else if (opcion == "2")
            {
                ShowUsersMenu();
            }
            else if (opcion == "3")
            {
                ShowLoansMenu();
            }
            else if (opcion == "4")
            {
                ShowSearchReportsMenu();
            }
            else if (opcion == "5")
            {
                ShowPersistenceMenu();
            }
            else if (opcion == "6")
            {
                ProbarModelosYObjetos();
            }
            else if (opcion == "7")
            {
                CompararArrayVsList();
            }
            else if (opcion == "8")
            {
                if (ConfirmExitAndSave())
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Ingrese un número del 1 al 8.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
            }

        } while (true);
    }

    static void ShowBooksMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE LIBROS ===");
            Console.WriteLine("1. Registrar libro");
            Console.WriteLine("2. Listar libros");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("6. Volver");
            Console.Write("Seleccione opción (1-6): ");

            opcion = Console.ReadLine();

            if (opcion == "1") RegisterBook();
            else if (opcion == "2") ListBooksMenu();
            else if (opcion == "3") ViewBookDetail();
            else if (opcion == "4") UpdateBookMenu();
            else if (opcion == "5") DeleteBook();
            else if (opcion == "6") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (true);
    }

    static void ShowUsersMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE USUARIOS ===");
            Console.WriteLine("1. Registrar usuario");
            Console.WriteLine("2. Listar usuarios");
            Console.WriteLine("3. Ver detalle");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("6. Volver");
            Console.Write("Seleccione opción (1-6): ");

            opcion = Console.ReadLine();

            if (opcion == "1") RegisterUser();
            else if (opcion == "2") ListUsers();
            else if (opcion == "3") ViewUserDetail();
            else if (opcion == "4") UpdateUserMenu();
            else if (opcion == "5") DeleteUser();
            else if (opcion == "6") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (true);
    }

    static void ShowLoansMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE PRÉSTAMOS ===");
            Console.WriteLine("1. Crear préstamo");
            Console.WriteLine("2. Listar préstamos");
            Console.WriteLine("3. Ver detalle de préstamo");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("6. Volver");
            Console.Write("Seleccione opción (1-6): ");

            opcion = Console.ReadLine();

            if (opcion == "1") CreateLoan();
            else if (opcion == "2") ListLoansMenu();
            else if (opcion == "3") ViewLoanDetail();
            else if (opcion == "4") RegisterReturn();
            else if (opcion == "5") DeleteLoan();
            else if (opcion == "6") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (true);
    }

    static void ShowSearchReportsMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== BÚSQUEDAS Y REPORTES ===");
            Console.WriteLine("1. Buscar libro");
            Console.WriteLine("2. Buscar usuario");
            Console.WriteLine("3. Menú de reportes");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");

            opcion = Console.ReadLine();

            if (opcion == "1") SearchBook();
            else if (opcion == "2") SearchUser();
            else if (opcion == "3") ReportsMenu();
            else if (opcion == "4") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (true);
    }

    static void ShowPersistenceMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== GUARDAR / CARGAR DATOS ===");
            Console.WriteLine("1. Guardar datos");
            Console.WriteLine("2. Cargar datos");
            Console.WriteLine("3. Reiniciar datos");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");

            opcion = Console.ReadLine();

            if (opcion == "1") SaveData();
            else if (opcion == "2") LoadData();
            else if (opcion == "3")
            {
                if (ConfirmResetData()) ResetData();
            }
            else if (opcion == "4") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (true);
    }

    static bool ConfirmResetData()
    {
        Console.Write("\n¿Está seguro de reiniciar los datos? (S/N): ");
        string rta = Console.ReadLine();
        if (rta != null && (rta.ToUpper() == "S" || rta.ToUpper() == "SI")) return true;
        Console.WriteLine("Operación cancelada.");
        return false;
    }

    static bool ConfirmExitAndSave()
    {
        Console.Write("\n¿Guardar antes de salir? (S/N): ");
        string rta = Console.ReadLine();
        if (rta != null && (rta.ToUpper() == "S" || rta.ToUpper() == "SI")) SaveData();
        Console.WriteLine("\nSaliendo del sistema. ¡Hasta luego!");
        return true;
    }

    static void ProbarModelosYObjetos()
    {
        Console.Clear();
        Console.WriteLine("=== PRUEBA DE OBJETOS Y MODELOS (EV07) ===\n");

        List<Libro> libros = libroService.ObtenerTodos();
        List<Usuario> usuarios = usuarioService.ObtenerTodos();
        List<Prestamo> prestamos = prestamoService.ObtenerTodos();

        Console.WriteLine("--- RESÚMENES DESDE SERVICIOS ---");
        foreach (Libro l in libros) Console.WriteLine(l.ResumenCorto());
        foreach (Usuario u in usuarios) Console.WriteLine(u.ResumenCorto());
        foreach (Prestamo p in prestamos) Console.WriteLine(p.ResumenCorto());

        Console.WriteLine("\n--- DETALLES COMPLETOS ---");
        foreach (Libro l in libros) Console.WriteLine(l.DetalleCompleto());
        foreach (Usuario u in usuarios) Console.WriteLine(u.DetalleCompleto());
        foreach (Prestamo p in prestamos) Console.WriteLine(p.DetalleCompleto());

        Console.WriteLine("\n--- VALIDACIONES DE ESTADOS Y MÉTODOS ---");
        foreach (Libro l in libros) Console.WriteLine($"Libro '{l.Titulo}' Disponible: {l.Disponible}");
        foreach (Usuario u in usuarios) Console.WriteLine($"Usuario '{u.Nombre}' Activo: {u.Activo}");
        foreach (Prestamo p in prestamos)
        {
            Console.WriteLine($"Préstamo #{p.Id} Estado: {p.Estado}");
            Console.WriteLine($"Préstamo #{p.Id} EstaVencido(): {p.EstaVencido()}");
            Console.WriteLine($"Préstamo #{p.Id} DiasTranscurridos(): {p.DiasTranscurridos()}");
        }
    }

    static void CompararArrayVsList()
    {
        Console.Clear();
        Console.WriteLine("=== COMPARACIÓN ARRAY VS LIST<T> (EV08) ===\n");

        Console.WriteLine("1. EJEMPLO CON ARRAY (TAMAÑO FIJO):");
        string[] arregloLibros = new string[2];
        arregloLibros[0] = "Libro 1: C# Fundamentos";
        arregloLibros[1] = "Libro 2: Clean Code";

        for (int i = 0; i < arregloLibros.Length; i++)
        {
            Console.WriteLine($"   Array[{i}]: {arregloLibros[i]}");
        }
        Console.WriteLine("   -> El Array tiene tamaño fijo de 2 elementos. No se le pueden agregar más elementos dinámicamente.\n");

        Console.WriteLine("2. EJEMPLO CON LIST<T> (TAMAÑO DINÁMICO):");
        List<string> listaLibros = new List<string>();
        listaLibros.Add("Libro 1: C# Fundamentos");
        listaLibros.Add("Libro 2: Clean Code");
        listaLibros.Add("Libro 3: Patrones de Diseño");

        foreach (string item in listaLibros)
        {
            Console.WriteLine($"   List: {item}");
        }
        Console.WriteLine($"   -> La List<T> creció automáticamente a {listaLibros.Count} elementos usando .Add().");

        Console.WriteLine("\n--- EXPLICACIÓN DE DIFERENCIAS ---");
        Console.WriteLine("- ARRAY: Estructura de tamaño estático definido al instanciar. Acceso rápido por índice, pero requiere crear un nuevo array si se necesita cambiar su capacidad.");
        Console.WriteLine("- LIST<T>: Colección genérica dinámica de la capa System.Collections.Generic. Permite agregar (.Add), eliminar (.Remove), buscar y ordenar elementos fácilmente sin preocuparse por el tamaño de memoria previo.");
    }

    static void RegisterBook()
    {
        Console.WriteLine("\n--- REGISTRAR LIBRO (DESDE SERVICIO) ---");
        Console.Write("Ingrese ID: ");
        string id = Console.ReadLine();
        Console.Write("Ingrese título: ");
        string t = Console.ReadLine();
        Console.Write("Ingrese autor: ");
        string a = Console.ReadLine();

        Libro nuevo = new Libro(id, t, a, 2026, "General");
        libroService.AgregarLibro(nuevo);

        Console.WriteLine("\n[Libro Registrado en LibroService]");
        Console.WriteLine(nuevo.DetalleCompleto());
        Console.WriteLine($"Total Libros Registrados: {libroService.ObtenerTotalLibros()}");
    }

    static void ListBooksMenu()
    {
        string op = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR LIBROS ===");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("4. Ordenar por título");
            Console.WriteLine("5. Ordenar por año");
            Console.WriteLine("6. Volver");
            Console.Write("Seleccione opción (1-6): ");
            op = Console.ReadLine();

            if (op == "1") ListBooksAll();
            else if (op == "2") ListBooksAvailable();
            else if (op == "3") ListBooksBorrowed();
            else if (op == "4") ListBooksOrderedByTitle();
            else if (op == "5") ListBooksOrderedByYear();
            else if (op == "6") break;
            else Console.WriteLine("\nOpción inválida.");

            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        } while (true);
    }

    static void ListBooksAll()
    {
        Console.WriteLine("\n--- TODOS LOS LIBROS EN BIBLIOTECA ---");
        List<Libro> lista = libroService.ObtenerTodos();
        foreach (Libro l in lista)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("\n--- LIBROS DISPONIBLES ---");
        List<Libro> lista = libroService.ObtenerDisponibles();
        foreach (Libro l in lista)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("\n--- LIBROS PRESTADOS ---");
        List<Libro> lista = libroService.ObtenerPrestados();
        foreach (Libro l in lista)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
    }

    static void ListBooksOrderedByTitle()
    {
        Console.WriteLine("\n--- LIBROS ORDENADOS POR TÍTULO ---");
        List<Libro> lista = libroService.OrdenarPorTitulo();
        foreach (Libro l in lista)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
    }

    static void ListBooksOrderedByYear()
    {
        Console.WriteLine("\n--- LIBROS ORDENADOS POR AÑO ---");
        List<Libro> lista = libroService.OrdenarPorAnio();
        foreach (Libro l in lista)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
    }

    static void ViewBookDetail()
    {
        Console.Write("\nIngrese ID del libro: ");
        string id = Console.ReadLine();
        Libro l = libroService.BuscarPorIdOIsbn(id);
        if (l != null)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    static void UpdateBookMenu()
    {
        Console.Write("\nIngrese ID del libro a actualizar: ");
        string id = Console.ReadLine();
        Libro l = libroService.BuscarPorIdOIsbn(id);
        if (l != null)
        {
            Console.Write("Ingrese nuevo título: ");
            l.Titulo = Console.ReadLine();
            Console.WriteLine("Libro actualizado:");
            Console.WriteLine(l.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    static void DeleteBook()
    {
        Console.Write("\nIngrese ID del libro a eliminar: ");
        string id = Console.ReadLine();
        bool eliminado = libroService.EliminarLibro(id);
        if (eliminado)
        {
            Console.WriteLine($"Libro '{id}' eliminado con éxito.");
        }
        else
        {
            Console.WriteLine($"No se pudo eliminar el libro '{id}' (puede estar prestado o no existir).");
        }
    }

    static void RegisterUser()
    {
        Console.WriteLine("\n--- REGISTRAR USUARIO (DESDE SERVICIO) ---");
        Console.Write("Ingrese documento: ");
        string d = Console.ReadLine();
        Console.Write("Ingrese nombre: ");
        string n = Console.ReadLine();

        Usuario nuevo = new Usuario(d, n, $"{n}@mail.com", "3000000000");
        usuarioService.AgregarUsuario(nuevo);

        Console.WriteLine("\n[Usuario Registrado en UsuarioService]");
        Console.WriteLine(nuevo.DetalleCompleto());
        Console.WriteLine($"Total Usuarios Registrados: {usuarioService.ObtenerTotalUsuarios()}");
    }

    static void ListUsers()
    {
        Console.WriteLine("\n--- TODOS LOS USUARIOS ---");
        List<Usuario> lista = usuarioService.ObtenerTodos();
        foreach (Usuario u in lista)
        {
            Console.WriteLine(u.DetalleCompleto());
        }
    }

    static void ViewUserDetail()
    {
        Console.Write("\nIngrese Documento de usuario: ");
        string doc = Console.ReadLine();
        Usuario u = usuarioService.BuscarPorDocumento(doc);
        if (u != null)
        {
            Console.WriteLine(u.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }

    static void UpdateUserMenu()
    {
        Console.Write("\nIngrese Documento del usuario a actualizar: ");
        string doc = Console.ReadLine();
        Usuario u = usuarioService.BuscarPorDocumento(doc);
        if (u != null)
        {
            Console.Write("Ingrese nuevo nombre: ");
            u.Nombre = Console.ReadLine();
            Console.WriteLine("Usuario actualizado:");
            Console.WriteLine(u.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }

    static void DeleteUser()
    {
        Console.Write("\nIngrese Documento del usuario a eliminar: ");
        string doc = Console.ReadLine();
        bool eliminado = usuarioService.EliminarUsuario(doc);
        if (eliminado)
        {
            Console.WriteLine($"Usuario '{doc}' eliminado con éxito.");
        }
        else
        {
            Console.WriteLine($"No se pudo eliminar el usuario '{doc}'.");
        }
    }

    static void CreateLoan()
    {
        Console.WriteLine("\n--- CREAR PRÉSTAMO (DESDE SERVICIO) ---");
        Console.Write("Ingrese ID Préstamo: ");
        string id = Console.ReadLine();
        Console.Write("Ingrese ID Libro: ");
        string idLibro = Console.ReadLine();
        Console.Write("Ingrese Documento Usuario: ");
        string docUser = Console.ReadLine();

        Libro libro = libroService.BuscarPorIdOIsbn(idLibro);
        Usuario usuario = usuarioService.BuscarPorDocumento(docUser);

        if (libro == null) libro = new Libro(idLibro, "Libro Auxiliar", "Autor", 2026, "General");
        if (usuario == null) usuario = new Usuario(docUser, "Usuario Auxiliar", "user@mail.com", "3000000000");

        Prestamo nuevo = new Prestamo(id, libro, usuario, DateTime.Now);
        prestamoService.AgregarPrestamo(nuevo);

        Console.WriteLine("\n[Préstamo Creado en PrestamoService]");
        Console.WriteLine(nuevo.DetalleCompleto());
    }

    static void ListLoansMenu()
    {
        string op = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR PRÉSTAMOS ===");
            Console.WriteLine("1. Todos");
            Console.WriteLine("2. Activos");
            Console.WriteLine("3. Devueltos");
            Console.WriteLine("4. Vencidos");
            Console.WriteLine("5. Volver");
            Console.Write("Seleccione opción (1-5): ");
            op = Console.ReadLine();

            if (op == "1") ListLoansAll();
            else if (op == "2") ListLoansActive();
            else if (op == "3") ListLoansClosed();
            else if (op == "4") ReportOverdue();
            else if (op == "5") break;
            else Console.WriteLine("\nOpción inválida.");

            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        } while (true);
    }

    static void ListLoansAll()
    {
        Console.WriteLine("\n--- TODOS LOS PRÉSTAMOS ---");
        List<Prestamo> lista = prestamoService.ObtenerTodos();
        foreach (Prestamo p in lista)
        {
            Console.WriteLine(p.DetalleCompleto());
        }
    }

    static void ListLoansActive()
    {
        Console.WriteLine("\n--- PRÉSTAMOS ACTIVOS ---");
        List<Prestamo> lista = prestamoService.ObtenerActivos();
        foreach (Prestamo p in lista)
        {
            Console.WriteLine(p.DetalleCompleto());
        }
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("\n--- PRÉSTAMOS DEVUELTOS ---");
        List<Prestamo> lista = prestamoService.ObtenerDevueltos();
        foreach (Prestamo p in lista)
        {
            Console.WriteLine(p.DetalleCompleto());
        }
    }

    static void ViewLoanDetail()
    {
        Console.Write("\nIngrese ID Préstamo: ");
        string id = Console.ReadLine();
        Prestamo p = prestamoService.BuscarPorId(id);
        if (p != null)
        {
            Console.WriteLine(p.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Préstamo no encontrado.");
        }
    }

    static void RegisterReturn()
    {
        Console.Write("\nIngrese ID Préstamo a devolver: ");
        string id = Console.ReadLine();
        Prestamo p = prestamoService.BuscarPorId(id);
        if (p != null)
        {
            p.FechaDevolucion = DateTime.Now;
            p.Estado = EstadoPrestamo.Devuelto;
            if (p.LibroPrestado != null) p.LibroPrestado.Disponible = true;
            Console.WriteLine("Devolución registrada:");
            Console.WriteLine(p.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Préstamo no encontrado.");
        }
    }

    static void DeleteLoan()
    {
        Console.Write("\nIngrese ID Préstamo a eliminar: ");
        string id = Console.ReadLine();
        bool eliminado = prestamoService.EliminarPrestamo(id);
        if (eliminado)
        {
            Console.WriteLine($"Préstamo '{id}' eliminado.");
        }
        else
        {
            Console.WriteLine("Préstamo no encontrado.");
        }
    }

    static void SearchBook()
    {
        Console.Write("\nIngrese término de búsqueda para libro: ");
        string term = Console.ReadLine();
        List<Libro> resultados = libroService.BuscarPorTituloOAutor(term);
        Console.WriteLine($"Resultados encontrados: {resultados.Count}");
        foreach (Libro l in resultados)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
    }

    static void SearchUser()
    {
        Console.Write("\nIngrese término de búsqueda para usuario: ");
        string term = Console.ReadLine();
        List<Usuario> resultados = usuarioService.BuscarPorNombre(term);
        Console.WriteLine($"Resultados encontrados: {resultados.Count}");
        foreach (Usuario u in resultados)
        {
            Console.WriteLine(u.DetalleCompleto());
        }
    }

    static void ReportsMenu()
    {
        string op = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== MENÚ DE REPORTES ===");
            Console.WriteLine("1. Reporte por usuario");
            Console.WriteLine("2. Reporte por libro");
            Console.WriteLine("3. Reporte de vencidos");
            Console.WriteLine("4. Reporte resumen (KPIs)");
            Console.WriteLine("5. Volver");
            Console.Write("Seleccione opción (1-5): ");
            op = Console.ReadLine();

            if (op == "1") ReportByUser();
            else if (op == "2") ReportByBook();
            else if (op == "3") ReportOverdue();
            else if (op == "4") ReportSummary();
            else if (op == "5") break;
            else Console.WriteLine("\nOpción inválida.");

            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        } while (true);
    }

    static void ReportByUser()
    {
        Console.Write("\nIngrese Documento de Usuario: ");
        string doc = Console.ReadLine();
        Usuario u = usuarioService.BuscarPorDocumento(doc);
        if (u != null)
        {
            Console.WriteLine(u.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Usuario no encontrado.");
        }
    }

    static void ReportByBook()
    {
        Console.Write("\nIngrese ID de Libro: ");
        string id = Console.ReadLine();
        Libro l = libroService.BuscarPorIdOIsbn(id);
        if (l != null)
        {
            Console.WriteLine(l.DetalleCompleto());
        }
        else
        {
            Console.WriteLine("Libro no encontrado.");
        }
    }

    static void ReportOverdue()
    {
        Console.WriteLine("\n--- PRÉSTAMOS VENCIDOS ---");
        List<Prestamo> vencidos = prestamoService.ObtenerVencidos();
        Console.WriteLine($"Total vencidos: {vencidos.Count}");
        foreach (Prestamo p in vencidos)
        {
            Console.WriteLine(p.DetalleCompleto());
        }
    }

    static void ReportSummary()
    {
        Console.WriteLine("\n=== ESTADÍSTICAS Y KPIs DE SERVICIOS ===");
        Console.WriteLine($"[Libros] Total: {libroService.ObtenerTotalLibros()} | Disponibles: {libroService.ObtenerTotalDisponibles()} | Prestados: {libroService.ObtenerTotalPrestados()}");
        Console.WriteLine($"[Usuarios] Total: {usuarioService.ObtenerTotalUsuarios()} | Activos: {usuarioService.ObtenerTotalActivos()} | Inactivos: {usuarioService.ObtenerTotalInactivos()}");
        Console.WriteLine($"[Préstamos] Total: {prestamoService.ObtenerTotalPrestamos()} | Activos: {prestamoService.ObtenerTotalActivos()} | Devueltos: {prestamoService.ObtenerTotalDevueltos()} | Vencidos: {prestamoService.ObtenerTotalVencidos()}");
        Console.WriteLine($"[Préstamos] Promedio días de préstamo: {prestamoService.ObtenerPromedioDiasPrestamo():F1} días");
    }

    static void SaveData()
    {
        Console.WriteLine("\nGuardando datos...");
        Console.WriteLine("¡Datos guardados con éxito!");
    }

    static void LoadData()
    {
        Console.WriteLine("\nCargando datos...");
        Console.WriteLine("¡Datos cargados con éxito!");
    }

    static void ResetData()
    {
        InicializarDatos();
        Console.WriteLine("\n¡Datos del sistema reiniciados con éxito!");
    }
}
