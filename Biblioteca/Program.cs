using System;
using Biblioteca.Models;

class Program
{
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

        Libro libro1 = new Libro("L001", "C# Avanzado", "John Skeet", 2021, "Programación");
        Libro libro2 = new Libro("L002", "Clean Code", "Robert C. Martin", 2008, "Ingeniería");

        Usuario usuario1 = new Usuario("10203040", "Ana Pérez", "ana@mail.com", "3001234567");
        Usuario usuario2 = new Usuario("50607080", "Carlos Ruiz", "carlos@mail.com", "3107654321");

        Prestamo prestamo1 = new Prestamo("P001", libro1, usuario1, DateTime.Now.AddDays(-3));

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
        Console.WriteLine($"Usuario 1 Activo: {usuario1.Activo}");
        Console.WriteLine($"Préstamo 1 Estado: {prestamo1.Estado}");
        Console.WriteLine($"Préstamo 1 Está Vencido?: {prestamo1.EstaVencido()}");
        Console.WriteLine($"Préstamo 1 Días Transcurridos: {prestamo1.DiasTranscurridos()}");

        Console.WriteLine("\nPrueba de objetos finalizada con éxito.");
        Console.WriteLine("Presione cualquier tecla para volver al menú...");
        Console.ReadKey();
    }

    static void RegisterBook()
    {
        Console.WriteLine("\n[Simulación] Registrando nuevo libro...");
        Console.Write("Ingrese título: ");
        string t = Console.ReadLine();
        Console.Write("Ingrese autor: ");
        string a = Console.ReadLine();
        Console.WriteLine($"Libro '{t}' de {a} registrado con éxito.");
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
        Console.WriteLine("\nListando todos los libros:");
        Console.WriteLine("- C# Guía Definitiva [Disponible]");
        Console.WriteLine("- Programación en .NET [Prestado]");
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("\nListando libros disponibles:");
        Console.WriteLine("- C# Guía Definitiva [Disponible]");
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("\nListando libros prestados:");
        Console.WriteLine("- Programación en .NET [Prestado]");
    }

    static void ViewBookDetail()
    {
        Console.Write("\nIngrese ID o ISBN: ");
        string id = Console.ReadLine();
        Console.WriteLine($"\nDetalle del libro {id}: Título: C# Básico, Estado: Disponible");
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
        Console.Write("Nuevo título: ");
        string val = Console.ReadLine();
        Console.WriteLine($"Título actualizado a: {val}");
    }

    static void EditBookAuthor()
    {
        Console.Write("Nuevo autor: ");
        string val = Console.ReadLine();
        Console.WriteLine($"Autor actualizado a: {val}");
    }

    static void EditBookYearCategory()
    {
        Console.Write("Nuevo año/categoría: ");
        string val = Console.ReadLine();
        Console.WriteLine($"Actualizado a: {val}");
    }

    static void DeleteBook()
    {
        Console.Write("\nID del libro a eliminar: ");
        string id = Console.ReadLine();
        Console.WriteLine($"Validar no permitir si está prestado. Libro {id} procesado.");
    }

    static void RegisterUser()
    {
        Console.WriteLine("\nRegistrando nuevo usuario...");
        Console.Write("Nombre: ");
        string n = Console.ReadLine();
        Console.Write("Documento: ");
        string d = Console.ReadLine();
        Console.WriteLine($"Usuario {n} registrado con éxito.");
    }

    static void ListUsers()
    {
        Console.WriteLine("\nListado de usuarios:");
        Console.WriteLine("- Carlos Pérez [Activo]");
        Console.WriteLine("- Ana Gómez [Activo]");
    }

    static void ViewUserDetail()
    {
        Console.Write("\nDocumento del usuario: ");
        string d = Console.ReadLine();
        Console.WriteLine($"Detalle del usuario {d}: Nombre: Carlos Pérez, Activo: True");
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
        Console.Write("Nuevo nombre: ");
        string val = Console.ReadLine();
        Console.WriteLine($"Nombre actualizado a: {val}");
    }

    static void EditUserContact()
    {
        Console.Write("Nuevo contacto: ");
        string val = Console.ReadLine();
        Console.WriteLine($"Contacto actualizado a: {val}");
    }

    static void ToggleUserActiveStatus()
    {
        Console.Write("Documento de usuario: ");
        string d = Console.ReadLine();
        Console.WriteLine($"Estado invertido para usuario {d}.");
    }

    static void DeleteUser()
    {
        Console.Write("\nDocumento de usuario a eliminar: ");
        string d = Console.ReadLine();
        Console.WriteLine($"Validar no permitir si tiene préstamos activos. Usuario {d} procesado.");
    }

    static void CreateLoan()
    {
        Console.WriteLine("\n--- CREAR PRÉSTAMO ---");
        Console.WriteLine("Validaciones: libro existe/disponible, usuario existe/activo, límite de préstamos.");
        Console.Write("ID Libro: ");
        string l = Console.ReadLine();
        Console.Write("Doc Usuario: ");
        string u = Console.ReadLine();
        Console.WriteLine($"Préstamo creado para libro {l} y usuario {u}.");
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
        Console.WriteLine("\nListando todos los préstamos:");
        Console.WriteLine("- Préstamo #1 [Activo]");
    }

    static void ListLoansActive()
    {
        Console.WriteLine("\nListando préstamos activos:");
        Console.WriteLine("- Préstamo #1 [Activo]");
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("\nListando préstamos cerrados:");
        Console.WriteLine("- Préstamo #2 [Cerrado]");
    }

    static void ViewLoanDetail()
    {
        Console.Write("\nID Préstamo: ");
        string id = Console.ReadLine();
        Console.WriteLine($"Detalle Préstamo #{id}: Activo");
    }

    static void RegisterReturn()
    {
        Console.Write("\nID Préstamo a devolver: ");
        string id = Console.ReadLine();
        Console.WriteLine($"Préstamo #{id} devuelto y libro disponible.");
    }

    static void DeleteLoan()
    {
        Console.Write("\nID Préstamo a eliminar: ");
        string id = Console.ReadLine();
        Console.WriteLine($"Préstamo #{id} eliminado.");
    }

    static void SearchBook()
    {
        Console.Write("\nTérmino de búsqueda de libro: ");
        string term = Console.ReadLine();
        Console.WriteLine($"Resultado para '{term}': C# Fundamentos");
    }

    static void SearchUser()
    {
        Console.Write("\nTérmino de búsqueda de usuario: ");
        string term = Console.ReadLine();
        Console.WriteLine($"Resultado para '{term}': María López");
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
        Console.Write("Documento de usuario: ");
        string doc = Console.ReadLine();
        Console.WriteLine($"Reporte de usuario {doc}: 1 activo.");
    }

    static void ReportByBook()
    {
        Console.Write("ID/ISBN libro: ");
        string isbn = Console.ReadLine();
        Console.WriteLine($"Reporte de libro {isbn}: 4 préstamos históricos.");
    }

    static void ReportOverdue()
    {
        Console.WriteLine("\nReporte de vencidos: Ninguno.");
    }

    static void ReportSummary()
    {
        Console.WriteLine("\nResumen general: 50 libros, 120 usuarios, 8 préstamos activos.");
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
