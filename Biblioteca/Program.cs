using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("========================================");
        Console.WriteLine("  SISTEMA DE BIBLIOTECA - CONSOLA C#");
        Console.WriteLine("========================================");
        ShowMainMenu();
    }

    // ==========================================
    // MENÚS Y NAVEGACIÓN
    // ==========================================
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
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción (1-6): ");
            
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
                if (ConfirmExitAndSave())
                {
                    break;
                }
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Por favor, ingrese un número del 1 al 6.");
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
            Console.WriteLine("3. Ver detalle (por ID/ISBN)");
            Console.WriteLine("4. Actualizar libro");
            Console.WriteLine("5. Eliminar libro");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Seleccione una opción (1-6): ");

            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                RegisterBook();
            }
            else if (opcion == "2")
            {
                ListBooksMenu();
            }
            else if (opcion == "3")
            {
                ViewBookDetail();
            }
            else if (opcion == "4")
            {
                UpdateBookMenu();
            }
            else if (opcion == "5")
            {
                DeleteBook();
            }
            else if (opcion == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Intente nuevamente.");
            }
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
            Console.WriteLine("3. Ver detalle (por ID/documento)");
            Console.WriteLine("4. Actualizar usuario");
            Console.WriteLine("5. Eliminar usuario");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Seleccione una opción (1-6): ");

            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                RegisterUser();
            }
            else if (opcion == "2")
            {
                ListUsers();
            }
            else if (opcion == "3")
            {
                ViewUserDetail();
            }
            else if (opcion == "4")
            {
                UpdateUserMenu();
            }
            else if (opcion == "5")
            {
                DeleteUser();
            }
            else if (opcion == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Intente nuevamente.");
            }
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
            Console.WriteLine("3. Ver detalle de préstamo (por ID)");
            Console.WriteLine("4. Registrar devolución");
            Console.WriteLine("5. Eliminar préstamo");
            Console.WriteLine("6. Volver al menú principal");
            Console.Write("Seleccione una opción (1-6): ");

            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                CreateLoan();
            }
            else if (opcion == "2")
            {
                ListLoansMenu();
            }
            else if (opcion == "3")
            {
                ViewLoanDetail();
            }
            else if (opcion == "4")
            {
                RegisterReturn();
            }
            else if (opcion == "5")
            {
                DeleteLoan();
            }
            else if (opcion == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Intente nuevamente.");
            }
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
            Console.WriteLine("4. Volver al menú principal");
            Console.Write("Seleccione una opción (1-4): ");

            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                SearchBook();
            }
            else if (opcion == "2")
            {
                SearchUser();
            }
            else if (opcion == "3")
            {
                ReportsMenu();
            }
            else if (opcion == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Intente nuevamente.");
            }
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
            Console.WriteLine("4. Volver al menú principal");
            Console.Write("Seleccione una opción (1-4): ");

            opcion = Console.ReadLine();

            if (opcion == "1")
            {
                SaveData();
            }
            else if (opcion == "2")
            {
                LoadData();
            }
            else if (opcion == "3")
            {
                if (ConfirmResetData())
                {
                    ResetData();
                }
            }
            else if (opcion == "4")
            {
                break;
            }
            else
            {
                Console.WriteLine("\n[Error] Opción no válida. Intente nuevamente.");
            }
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();

        } while (true);
    }

    static bool ConfirmResetData()
    {
        Console.Write("\n¿Está seguro de reiniciar los datos? (S/N): ");
        string rta = Console.ReadLine();
        if (rta != null && (rta.ToUpper() == "S" || rta.ToUpper() == "SI"))
        {
            return true;
        }
        Console.WriteLine("Operación cancelada.");
        return false;
    }

    static bool ConfirmExitAndSave()
    {
        Console.Write("\n¿Guardar antes de salir? (S/N): ");
        string rta = Console.ReadLine();
        if (rta != null && (rta.ToUpper() == "S" || rta.ToUpper() == "SI"))
        {
            SaveData();
        }
        Console.WriteLine("\nSaliendo del sistema de biblioteca. ¡Hasta luego!");
        return true;
    }

    // ==========================================
    // 1) MÓDULO LIBROS
    // ==========================================
    static void RegisterBook()
    {
        Console.WriteLine("\n[Simulación] -> Registrando nuevo libro en el sistema...");
        Console.Write("Ingrese título del libro: ");
        string titulo = Console.ReadLine();
        Console.Write("Ingrese autor: ");
        string autor = Console.ReadLine();
        Console.WriteLine($"¡Libro '{titulo}' de {autor} registrado con éxito (Disponible = true)!");
    }

    static void ListBooksMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR LIBROS ===");
            Console.WriteLine("1. Listar todos");
            Console.WriteLine("2. Listar disponibles");
            Console.WriteLine("3. Listar prestados");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            opcion = Console.ReadLine();

            if (opcion == "1") ListBooksAll();
            else if (opcion == "2") ListBooksAvailable();
            else if (opcion == "3") ListBooksBorrowed();
            else if (opcion == "4") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (true);
    }

    static void ListBooksAll()
    {
        Console.WriteLine("\n[Simulación] Listando todos los libros de la biblioteca:");
        Console.WriteLine("- C# Guía Definitiva (Autor: J. Albahari) [Disponible]");
        Console.WriteLine("- Programación en .NET (Autor: A. Freeman) [Prestado]");
    }

    static void ListBooksAvailable()
    {
        Console.WriteLine("\n[Simulación] Listando libros disponibles:");
        Console.WriteLine("- C# Guía Definitiva (Autor: J. Albahari) [Disponible]");
    }

    static void ListBooksBorrowed()
    {
        Console.WriteLine("\n[Simulación] Listando libros prestados:");
        Console.WriteLine("- Programación en .NET (Autor: A. Freeman) [Prestado]");
    }

    static void ViewBookDetail()
    {
        Console.Write("\nIngrese ID o ISBN del libro: ");
        string id = Console.ReadLine();
        Console.WriteLine($"\n[Simulación] Detalle del libro con ID/ISBN '{id}':");
        Console.WriteLine($"Título: Programación C#, ISBN: {id}, Categoría: Tecnología, Estado: Disponible");
    }

    static void UpdateBookMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR LIBRO ===");
            Console.WriteLine("1. Editar título");
            Console.WriteLine("2. Editar autor");
            Console.WriteLine("3. Editar año / categoría");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            opcion = Console.ReadLine();

            if (opcion == "1") EditBookTitle();
            else if (opcion == "2") EditBookAuthor();
            else if (opcion == "3") EditBookYearCategory();
            else if (opcion == "4") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (true);
    }

    static void EditBookTitle()
    {
        Console.Write("Ingrese nuevo título para el libro: ");
        string nuevoTitulo = Console.ReadLine();
        Console.WriteLine($"[Simulación] Título actualizado exitosamente a: '{nuevoTitulo}'.");
    }

    static void EditBookAuthor()
    {
        Console.Write("Ingrese nuevo autor: ");
        string nuevoAutor = Console.ReadLine();
        Console.WriteLine($"[Simulación] Autor actualizado exitosamente a: '{nuevoAutor}'.");
    }

    static void EditBookYearCategory()
    {
        Console.Write("Ingrese nuevo año y categoría: ");
        string datos = Console.ReadLine();
        Console.WriteLine($"[Simulación] Año/Categoría actualizados a: '{datos}'.");
    }

    static void DeleteBook()
    {
        Console.Write("\nIngrese ID del libro a eliminar: ");
        string id = Console.ReadLine();
        Console.WriteLine($"[Simulación] Validar no permitir eliminar si está prestado. Libro {id} eliminado correctamente (simulación).");
    }

    // ==========================================
    // 2) MÓDULO USUARIOS
    // ==========================================
    static void RegisterUser()
    {
        Console.WriteLine("\n[Simulación] -> Registrando nuevo usuario...");
        Console.Write("Ingrese nombre del usuario: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese número de documento: ");
        string doc = Console.ReadLine();
        Console.WriteLine($"¡Usuario {nombre} (Doc: {doc}) registrado con éxito (Activo = true)!");
    }

    static void ListUsers()
    {
        Console.WriteLine("\n[Simulación] Listando usuarios registrados:");
        Console.WriteLine("- Carlos Pérez (Doc: 10102030) [Activo]");
        Console.WriteLine("- Ana Gómez (Doc: 40506070) [Activo]");
    }

    static void ViewUserDetail()
    {
        Console.Write("\nIngrese ID o documento del usuario: ");
        string doc = Console.ReadLine();
        Console.WriteLine($"\n[Simulación] Detalle del usuario con Documento '{doc}':");
        Console.WriteLine($"Nombre: Carlos Pérez, Documento: {doc}, Contacto: carlos@email.com, Estado: Activo");
    }

    static void UpdateUserMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== ACTUALIZAR USUARIO ===");
            Console.WriteLine("1. Editar nombre");
            Console.WriteLine("2. Editar contacto");
            Console.WriteLine("3. Activar / desactivar");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            opcion = Console.ReadLine();

            if (opcion == "1") EditUserName();
            else if (opcion == "2") EditUserContact();
            else if (opcion == "3") ToggleUserActiveStatus();
            else if (opcion == "4") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (true);
    }

    static void EditUserName()
    {
        Console.Write("Ingrese nuevo nombre de usuario: ");
        string nuevoNombre = Console.ReadLine();
        Console.WriteLine($"[Simulación] Nombre actualizado a: '{nuevoNombre}'.");
    }

    static void EditUserContact()
    {
        Console.Write("Ingrese nuevo contacto (teléfono/email): ");
        string contacto = Console.ReadLine();
        Console.WriteLine($"[Simulación] Contacto actualizado a: '{contacto}'.");
    }

    static void ToggleUserActiveStatus()
    {
        Console.Write("Ingrese documento del usuario a cambiar estado: ");
        string doc = Console.ReadLine();
        Console.WriteLine($"[Simulación] Estado activo/inactivo invertido para el usuario {doc}.");
    }

    static void DeleteUser()
    {
        Console.Write("\nIngrese documento del usuario a eliminar: ");
        string doc = Console.ReadLine();
        Console.WriteLine($"[Simulación] Validar no permitir si tiene préstamos activos. Usuario {doc} eliminado.");
    }

    // ==========================================
    // 3) MÓDULO PRÉSTAMOS
    // ==========================================
    static void CreateLoan()
    {
        Console.WriteLine("\n[Simulación] --- CREAR PRÉSTAMO ---");
        Console.WriteLine("Lista de validaciones sugeridas:");
        Console.WriteLine("1. Validar que el libro exista y esté disponible.");
        Console.WriteLine("2. Validar que el usuario exista y esté activo.");
        Console.WriteLine("3. Validar límite de préstamos por usuario.");
        Console.Write("Ingrese ID del libro: ");
        string idLibro = Console.ReadLine();
        Console.Write("Ingrese documento del usuario: ");
        string docUser = Console.ReadLine();
        Console.WriteLine($"[Simulación] ¡Préstamo creado con éxito para el libro {idLibro} y usuario {docUser}!");
    }

    static void ListLoansMenu()
    {
        string opcion = "";
        do
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR PRÉSTAMOS ===");
            Console.WriteLine("1. Todos");
            Console.WriteLine("2. Activos");
            Console.WriteLine("3. Cerrados");
            Console.WriteLine("4. Volver");
            Console.Write("Seleccione opción (1-4): ");
            opcion = Console.ReadLine();

            if (opcion == "1") ListLoansAll();
            else if (opcion == "2") ListLoansActive();
            else if (opcion == "3") ListLoansClosed();
            else if (opcion == "4") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (true);
    }

    static void ListLoansAll()
    {
        Console.WriteLine("\n[Simulación] Listando todos los préstamos:");
        Console.WriteLine("- Préstamo #1: Libro 'Programación en .NET' a Carlos Pérez [Activo]");
        Console.WriteLine("- Préstamo #2: Libro 'C# Guía Definitiva' a Ana Gómez [Cerrado]");
    }

    static void ListLoansActive()
    {
        Console.WriteLine("\n[Simulación] Listando préstamos activos:");
        Console.WriteLine("- Préstamo #1: Libro 'Programación en .NET' a Carlos Pérez [Activo]");
    }

    static void ListLoansClosed()
    {
        Console.WriteLine("\n[Simulación] Listando préstamos cerrados:");
        Console.WriteLine("- Préstamo #2: Libro 'C# Guía Definitiva' a Ana Gómez [Cerrado]");
    }

    static void ViewLoanDetail()
    {
        Console.Write("\nIngrese ID del préstamo: ");
        string idPrestamo = Console.ReadLine();
        Console.WriteLine($"\n[Simulación] Detalle del préstamo #{idPrestamo}:");
        Console.WriteLine($"Libro: Programación en .NET, Usuario: Carlos Pérez, Fecha Préstamo: 2026-03-01, Estado: Activo");
    }

    static void RegisterReturn()
    {
        Console.Write("\nIngrese ID del préstamo a devolver: ");
        string id = Console.ReadLine();
        Console.WriteLine($"[Simulación] Préstamo #{id} marcado como devuelto y libro marcado como disponible.");
    }

    static void DeleteLoan()
    {
        Console.Write("\nIngrese ID del préstamo a eliminar: ");
        string id = Console.ReadLine();
        Console.WriteLine($"[Simulación] Préstamo #{id} eliminado del registro (reglas sugeridas aplicadas).");
    }

    // ==========================================
    // 4) BÚSQUEDAS Y REPORTES
    // ==========================================
    static void SearchBook()
    {
        Console.Write("\nIngrese término de búsqueda (título/autor/id/categoría): ");
        string termino = Console.ReadLine();
        Console.WriteLine($"\n[Simulación] Resultados de búsqueda de libro para '{termino}':");
        Console.WriteLine($"- Encontrado: 'C# Fundamentos' (Autor: Juan Pérez, Categoría: Programación)");
    }

    static void SearchUser()
    {
        Console.Write("\nIngrese término de búsqueda (nombre/id): ");
        string termino = Console.ReadLine();
        Console.WriteLine($"\n[Simulación] Resultados de búsqueda de usuario para '{termino}':");
        Console.WriteLine($"- Encontrado: María López (Doc: 98765432)");
    }

    static void ReportsMenu()
    {
        string opcion = "";
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
            opcion = Console.ReadLine();

            if (opcion == "1") ReportByUser();
            else if (opcion == "2") ReportByBook();
            else if (opcion == "3") ReportOverdue();
            else if (opcion == "4") ReportSummary();
            else if (opcion == "5") break;
            else Console.WriteLine("\n[Error] Opción inválida.");

            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey();
        } while (true);
    }

    static void ReportByUser()
    {
        Console.Write("Ingrese documento del usuario para el reporte: ");
        string doc = Console.ReadLine();
        Console.WriteLine($"\n[Simulación] Generando reporte de préstamos para el usuario {doc}:");
        Console.WriteLine("- 1 préstamo activo, 2 préstamos históricos.");
    }

    static void ReportByBook()
    {
        Console.Write("Ingrese ID/ISBN del libro para el reporte: ");
        string isbn = Console.ReadLine();
        Console.WriteLine($"\n[Simulación] Generando historial de préstamos para el libro {isbn}:");
        Console.WriteLine("- Prestado 4 veces en total.");
    }

    static void ReportOverdue()
    {
        Console.WriteLine("\n[Simulación] Generando reporte de préstamos vencidos:");
        Console.WriteLine("- No hay préstamos vencidos actualmente.");
    }

    static void ReportSummary()
    {
        Console.WriteLine("\n[Simulación] Resumen general del sistema de biblioteca:");
        Console.WriteLine("- Total libros: 50 | Disponibles: 42 | Prestados: 8");
        Console.WriteLine("- Total usuarios activos: 120");
        Console.WriteLine("- Total préstamos activos: 8");
    }

    // ==========================================
    // 5) GUARDAR / CARGAR DATOS
    // ==========================================
    static void SaveData()
    {
        Console.WriteLine("\n[Simulación] Guardando todos los datos del sistema de biblioteca...");
        Console.WriteLine("¡Datos guardados exitosamente!");
    }

    static void LoadData()
    {
        Console.WriteLine("\n[Simulación] Cargando datos del sistema de biblioteca...");
        Console.WriteLine("¡Datos cargados exitosamente!");
    }

    static void ResetData()
    {
        Console.WriteLine("\n[Simulación] Reiniciando datos del sistema a valores iniciales...");
        Console.WriteLine("¡Sistema reiniciado con éxito!");
    }
}
