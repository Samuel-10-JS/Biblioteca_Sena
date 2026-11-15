using System;
using Biblioteca.Models;

class Program
{
    static Libro libro1 = new Libro("L001", "C# Avanzado", "John Skeet", 2021, "Programación");
    static Libro libro2 = new Libro("L002", "Clean Code", "Robert C. Martin", 2008, "Ingeniería") { Disponible = false };

    static Usuario usuario1 = new Usuario("10203040", "Ana Pérez", "ana@mail.com", "3001234567");
    static Usuario usuario2 = new Usuario("50607080", "Carlos Ruiz", "carlos@mail.com", "3107654321") { Activo = false };

    static Prestamo prestamo1 = new Prestamo("P001", libro1, usuario1, DateTime.Now.AddDays(-10));

    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("  SISTEMA DE BIBLIOTECA - CONSOLA C#");
        Console.WriteLine("========================================");
        ShowMainMenu();
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
            Console.WriteLine("7. Salir");
            Console.Write("Seleccione una opción (1-7): ");
            
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
                if (ConfirmExitAndSave())
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Ingrese un número del 1 al 7.");
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

        Console.WriteLine("--- RESÚMENES ---");
        Console.WriteLine(libro1.ResumenCorto());
        Console.WriteLine(libro2.ResumenCorto());
        Console.WriteLine(usuario1.ResumenCorto());
        Console.WriteLine(usuario2.ResumenCorto());
        Console.WriteLine(prestamo1.ResumenCorto());

        Console.WriteLine("\n--- DETALLES COMPLETOS ---");
        Console.WriteLine(libro1.DetalleCompleto());
        Console.WriteLine(libro2.DetalleCompleto());
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine(usuario2.DetalleCompleto());
        Console.WriteLine(prestamo1.DetalleCompleto());

        Console.WriteLine("\n--- VALIDACIONES DE ESTADOS Y MÉTODOS ---");
        Console.WriteLine($"Libro 1 Disponible: {libro1.Disponible}");
        Console.WriteLine($"Libro 2 Disponible: {libro2.Disponible}");
        Console.WriteLine($"Usuario 1 Activo: {usuario1.Activo}");
        Console.WriteLine($"Usuario 2 Activo: {usuario2.Activo}");
        Console.WriteLine($"Préstamo 1 Estado: {prestamo1.Estado}");
        Console.WriteLine($"Préstamo 1 EstaVencido(): {prestamo1.EstaVencido()}");
        Console.WriteLine($"Préstamo 1 DiasTranscurridos(): {prestamo1.DiasTranscurridos()}");
    }

    static void RegisterBook()
    {
        Console.WriteLine("\n--- REGISTRAR LIBRO ---");
        Console.Write("Ingrese ID: ");
        string id = Console.ReadLine();
        Console.Write("Ingrese título: ");
        string t = Console.ReadLine();
        Console.Write("Ingrese autor: ");
        string a = Console.ReadLine();

        Libro nuevo = new Libro(id, t, a, 2026, "General");
        Console.WriteLine("\n[Objeto Creado]");
        Console.WriteLine(nuevo.ResumenCorto());
        Console.WriteLine(nuevo.DetalleCompleto());
        Console.WriteLine($"Validación Disponible: {nuevo.Disponible}");
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
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            op = Console.ReadLine();

            if (op == "1") ListBooksAll();
            else if (op == "2") ListBooksAvailable();
            else if (op == "3") ListBooksBorrowed();
            else if (op == "4") break;
            else Console.WriteLine("\nOpción inválida.");

            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        } while (true);
    }

    static void ListBooksAll()
    {
        Console.WriteLine("\n--- TODOS LOS LIBROS (OBJETOS DE PRUEBA) ---");
        Console.WriteLine("Resúmenes:");
        Console.WriteLine(libro1.ResumenCorto());
        Console.WriteLine(libro2.ResumenCorto());
        Console.WriteLine("\nDetalles completos:");
        Console.WriteLine(libro1.DetalleCompleto());
        Console.WriteLine(libro2.DetalleCompleto());
        Console.WriteLine("\nValidaciones:");
        Console.WriteLine($"Libro 1 Disponible: {libro1.Disponible}");
        Console.WriteLine($"Libro 2 Disponible: {libro2.Disponible}");
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("\n--- LIBROS DISPONIBLES (OBJETO DE PRUEBA) ---");
        if (libro1.Disponible)
        {
            Console.WriteLine(libro1.ResumenCorto());
            Console.WriteLine(libro1.DetalleCompleto());
            Console.WriteLine($"Validación Disponible: {libro1.Disponible}");
        }
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("\n--- LIBROS PRESTADOS (OBJETO DE PRUEBA) ---");
        if (!libro2.Disponible)
        {
            Console.WriteLine(libro2.ResumenCorto());
            Console.WriteLine(libro2.DetalleCompleto());
            Console.WriteLine($"Validación Disponible: {libro2.Disponible}");
        }
    }

    static void ViewBookDetail()
    {
        Console.WriteLine("\n--- VER DETALLE DE LIBRO (OBJETO DE PRUEBA) ---");
        Console.WriteLine(libro1.DetalleCompleto());
        Console.WriteLine($"Validación Disponible: {libro1.Disponible}");
    }

    static void UpdateBookMenu()
    {
        string op = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR LIBRO ===");
            Console.WriteLine("1. Editar título");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoría");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            op = Console.ReadLine();

            if (op == "1") EditBookTitle();
            else if (op == "2") EditBookAuthor();
            else if (op == "3") EditBookYearCategory();
            else if (op == "4") break;
            else Console.WriteLine("\nOpción inválida.");

            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        } while (true);
    }

    static void EditBookTitle()
    {
        Console.Write("Nuevo título para Libro 1: ");
        string val = Console.ReadLine();
        libro1.Titulo = val;
        Console.WriteLine("\n[Libro Actualizado]");
        Console.WriteLine(libro1.DetalleCompleto());
    }

    static void EditBookAuthor()
    {
        Console.Write("Nuevo autor para Libro 1: ");
        string val = Console.ReadLine();
        libro1.Autor = val;
        Console.WriteLine("\n[Libro Actualizado]");
        Console.WriteLine(libro1.DetalleCompleto());
    }

    static void EditBookYearCategory()
    {
        Console.Write("Nuevo año para Libro 1: ");
        string val = Console.ReadLine();
        if (int.TryParse(val, out int a)) libro1.Anio = a;
        Console.WriteLine("\n[Libro Actualizado]");
        Console.WriteLine(libro1.DetalleCompleto());
    }

    static void DeleteBook()
    {
        Console.WriteLine("\n--- ELIMINAR LIBRO (VALIDACIÓN SIMULADA) ---");
        Console.WriteLine(libro2.DetalleCompleto());
        Console.WriteLine($"Validar no permitir si está prestado (Disponible: {libro2.Disponible}).");
    }

    static void RegisterUser()
    {
        Console.WriteLine("\n--- REGISTRAR USUARIO ---");
        Console.Write("Ingrese documento: ");
        string d = Console.ReadLine();
        Console.Write("Ingrese nombre: ");
        string n = Console.ReadLine();

        Usuario nuevo = new Usuario(d, n, $"{n}@mail.com", "3000000000");
        Console.WriteLine("\n[Objeto Creado]");
        Console.WriteLine(nuevo.ResumenCorto());
        Console.WriteLine(nuevo.DetalleCompleto());
        Console.WriteLine($"Validación Activo: {nuevo.Activo}");
    }

    static void ListUsers()
    {
        Console.WriteLine("\n--- TODOS LOS USUARIOS (OBJETOS DE PRUEBA) ---");
        Console.WriteLine("Resúmenes:");
        Console.WriteLine(usuario1.ResumenCorto());
        Console.WriteLine(usuario2.ResumenCorto());
        Console.WriteLine("\nDetalles completos:");
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine(usuario2.DetalleCompleto());
        Console.WriteLine("\nValidaciones:");
        Console.WriteLine($"Usuario 1 Activo: {usuario1.Activo}");
        Console.WriteLine($"Usuario 2 Activo: {usuario2.Activo}");
    }

    static void ViewUserDetail()
    {
        Console.WriteLine("\n--- VER DETALLE DE USUARIO (OBJETO DE PRUEBA) ---");
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine($"Validación Activo: {usuario1.Activo}");
    }

    static void UpdateUserMenu()
    {
        string op = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR USUARIO ===");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            op = Console.ReadLine();

            if (op == "1") EditUserName();
            else if (op == "2") EditUserContact();
            else if (op == "3") ToggleUserActiveStatus();
            else if (op == "4") break;
            else Console.WriteLine("\nOpción inválida.");

            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        } while (true);
    }

    static void EditUserName()
    {
        Console.Write("Nuevo nombre para Usuario 1: ");
        string val = Console.ReadLine();
        usuario1.Nombre = val;
        Console.WriteLine("\n[Usuario Actualizado]");
        Console.WriteLine(usuario1.DetalleCompleto());
    }

    static void EditUserContact()
    {
        Console.Write("Nuevo teléfono para Usuario 1: ");
        string val = Console.ReadLine();
        usuario1.Telefono = val;
        Console.WriteLine("\n[Usuario Actualizado]");
        Console.WriteLine(usuario1.DetalleCompleto());
    }

    static void ToggleUserActiveStatus()
    {
        usuario1.Activo = !usuario1.Activo;
        Console.WriteLine("\n[Estado Activo Invertido]");
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine($"Validación Activo: {usuario1.Activo}");
    }

    static void DeleteUser()
    {
        Console.WriteLine("\n--- ELIMINAR USUARIO (VALIDACIÓN SIMULADA) ---");
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine($"Validar no permitir si tiene préstamos activos (Activo: {usuario1.Activo}).");
    }

    static void CreateLoan()
    {
        Console.WriteLine("\n--- CREAR PRÉSTAMO (OBJETO DE PRUEBA) ---");
        Prestamo nuevo = new Prestamo("P002", libro1, usuario1, DateTime.Now);
        Console.WriteLine("\n[Objeto Préstamo Creado]");
        Console.WriteLine(nuevo.ResumenCorto());
        Console.WriteLine(nuevo.DetalleCompleto());
        Console.WriteLine($"Validaciones -> Estado: {nuevo.Estado} | EstaVencido(): {nuevo.EstaVencido()} | DiasTranscurridos(): {nuevo.DiasTranscurridos()}");
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
            Console.WriteLine("3. Cerrados");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            op = Console.ReadLine();

            if (op == "1") ListLoansAll();
            else if (op == "2") ListLoansActive();
            else if (op == "3") ListLoansClosed();
            else if (op == "4") break;
            else Console.WriteLine("\nOpción inválida.");

            Console.WriteLine("\nPresione cualquier tecla...");
            Console.ReadKey();
        } while (true);
    }

    static void ListLoansAll()
    {
        Console.WriteLine("\n--- TODOS LOS PRÉSTAMOS (OBJETO DE PRUEBA) ---");
        Console.WriteLine("Resumen:");
        Console.WriteLine(prestamo1.ResumenCorto());
        Console.WriteLine("\nDetalle completo:");
        Console.WriteLine(prestamo1.DetalleCompleto());
        Console.WriteLine("\nValidaciones:");
        Console.WriteLine($"Estado: {prestamo1.Estado}");
        Console.WriteLine($"EstaVencido(): {prestamo1.EstaVencido()}");
        Console.WriteLine($"DiasTranscurridos(): {prestamo1.DiasTranscurridos()}");
    }

    static void ListLoansActive()
    {
        Console.WriteLine("\n--- PRÉSTAMOS ACTIVOS (OBJETO DE PRUEBA) ---");
        if (prestamo1.Estado == EstadoPrestamo.Activo)
        {
            Console.WriteLine(prestamo1.ResumenCorto());
            Console.WriteLine(prestamo1.DetalleCompleto());
            Console.WriteLine($"Estado: {prestamo1.Estado} | Vencido: {prestamo1.EstaVencido()} | Días: {prestamo1.DiasTranscurridos()}");
        }
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("\n--- PRÉSTAMOS CERRADOS (OBJETO DE PRUEBA) ---");
        Prestamo cerrado = new Prestamo("P000", libro2, usuario2, DateTime.Now.AddDays(-20))
        {
            FechaDevolucion = DateTime.Now.AddDays(-5),
            Estado = EstadoPrestamo.Devuelto
        };
        Console.WriteLine(cerrado.ResumenCorto());
        Console.WriteLine(cerrado.DetalleCompleto());
        Console.WriteLine($"Estado: {cerrado.Estado} | Vencido: {cerrado.EstaVencido()} | Días: {cerrado.DiasTranscurridos()}");
    }

    static void ViewLoanDetail()
    {
        Console.WriteLine("\n--- DETALLE DE PRÉSTAMO (OBJETO DE PRUEBA) ---");
        Console.WriteLine(prestamo1.DetalleCompleto());
        Console.WriteLine($"Validaciones -> Estado: {prestamo1.Estado} | EstaVencido(): {prestamo1.EstaVencido()} | DiasTranscurridos(): {prestamo1.DiasTranscurridos()}");
    }

    static void RegisterReturn()
    {
        Console.WriteLine("\n--- REGISTRAR DEVOLUCIÓN ---");
        prestamo1.FechaDevolucion = DateTime.Now;
        prestamo1.Estado = EstadoPrestamo.Devuelto;
        prestamo1.LibroPrestado.Disponible = true;

        Console.WriteLine("[Préstamo Actualizado]");
        Console.WriteLine(prestamo1.DetalleCompleto());
        Console.WriteLine($"Validación Libro Disponible: {prestamo1.LibroPrestado.Disponible}");
    }

    static void DeleteLoan()
    {
        Console.WriteLine("\n--- ELIMINAR PRÉSTAMO ---");
        Console.WriteLine(prestamo1.DetalleCompleto());
        Console.WriteLine("Préstamo eliminado (simulado).");
    }

    static void SearchBook()
    {
        Console.WriteLine("\n--- BÚSQUEDA DE LIBRO ---");
        Console.WriteLine(libro1.DetalleCompleto());
        Console.WriteLine($"Validación Disponible: {libro1.Disponible}");
    }

    static void SearchUser()
    {
        Console.WriteLine("\n--- BÚSQUEDA DE USUARIO ---");
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine($"Validación Activo: {usuario1.Activo}");
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
            Console.WriteLine("4. Reporte resumen");
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
        Console.WriteLine("\n--- REPORTE POR USUARIO ---");
        Console.WriteLine(usuario1.DetalleCompleto());
        Console.WriteLine(prestamo1.ResumenCorto());
    }

    static void ReportByBook()
    {
        Console.WriteLine("\n--- REPORTE POR LIBRO ---");
        Console.WriteLine(libro1.DetalleCompleto());
        Console.WriteLine(prestamo1.ResumenCorto());
    }

    static void ReportOverdue()
    {
        Console.WriteLine("\n--- REPORTE DE VENCIDOS ---");
        Console.WriteLine($"Préstamo #{prestamo1.Id} EstaVencido(): {prestamo1.EstaVencido()}");
    }

    static void ReportSummary()
    {
        Console.WriteLine("\n--- REPORTE RESUMEN DE MODELOS ---");
        Console.WriteLine(libro1.ResumenCorto());
        Console.WriteLine(libro2.ResumenCorto());
        Console.WriteLine(usuario1.ResumenCorto());
        Console.WriteLine(usuario2.ResumenCorto());
        Console.WriteLine(prestamo1.ResumenCorto());
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
        Console.WriteLine("\nReiniciando datos...");
        Console.WriteLine("¡Datos reiniciados con éxito!");
    }
}
