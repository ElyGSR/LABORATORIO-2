const int LONGITUD_MINIMA_CODIGO = 6;

static void VerMenu()
{
    Console.WriteLine("===== SOPORTE ACADÉMICO =====");
    Console.WriteLine("1. Registrar solicitud");
    Console.WriteLine("2. Ver resumen");
    Console.WriteLine("3. Salir");
}
// Req. 8: parámetro por valor (copia). Solo lee el código, no lo modifica.
static bool ValidarCodigoEstudiante(string codigox)
{
    if (codigox.Length < LONGITUD_MINIMA_CODIGO)
    {
        return false;
    }
    return true;
}
// Req. 8: parámetro por valor. Recibe el tipo y devuelve true o false.

static bool ValidarTipoConsulta(string tipox)
{
    if (tipox == "matricula")
    {
        return true;
    }
    if (tipox == "pagos")
    {
        return true;
    }
    if (tipox == "constancia")
    {
        return true;
    }
    if (tipox == "plataforma")
    {
        return true;
    }
    if (tipox == "otro")
    {
        return true;
    }
    return false;
}
// Req. 8: parámetro por valor. Sirve para validar cualquier texto obligatorio.
static bool ValidarTextoObligatorio(string textox)
{
    if (textox.Length == 0)
    {
        return false;
    }
    return true;
}
// Req. 8: parámetro por valor. Recibe el tipo y devuelve la prioridad.
static string CalcularPrioridad(string tipox)
{
 // Req. 9: tipox es una variable local (parámetro). Solo existe dentro de esta función.

    if (tipox == "matricula" || tipox == "pagos")
    {
        return "Alta";
    }
    if (tipox == "constancia" || tipox == "plataforma")
    {
        return "Media";
    }
    return "Baja";
}
// Req. 8: parámetros por valor. Solo muestra los datos, no los modifica.
static void MostrarResumen(string codigox, string nombrex, string tipox, string descripcionx, string prioridadx)
{
    Console.WriteLine("===== RESUMEN DE LA SOLICITUD =====");
    Console.WriteLine($"Código: {codigox}");
    Console.WriteLine($"Nombre: {nombrex}");
    Console.WriteLine($"Tipo de consulta: {tipox}");
    Console.WriteLine($"Descripción: {descripcionx}");
    Console.WriteLine($"Prioridad: {prioridadx}");
}
// Req. 8: parámetros por referencia (ref). Llena las variables del programa principal.
static void RegistrarDatos(ref string codigo, ref string nombre, ref string tipoConsulta, ref string descripcion)
{
    Console.Write("Ingrese código de estudiante: ");
    codigo = Console.ReadLine();
    Console.Write("Ingrese nombre: ");
    nombre = Console.ReadLine();
    Console.Write("Ingrese tipo de consulta: ");
    tipoConsulta = Console.ReadLine();
    Console.Write("Ingrese descripción breve: ");
    descripcion = Console.ReadLine();
}

Console.WriteLine("Bienvenido al sistema de soporte académico");
VerMenu();
// Req. 9: variables del programa principal. Existen durante toda la ejecución.

string codigo = "";
string nombre = "";
string tipoConsulta = "";
string descripcion = "";
RegistrarDatos(ref codigo, ref nombre, ref tipoConsulta, ref descripcion);
if (ValidarCodigoEstudiante(codigo))
{
    Console.WriteLine("Código válido.");
}
else
{
    Console.WriteLine("Error: el código está vacío o es demasiado corto.");
}
if (ValidarTipoConsulta(tipoConsulta))
{
    Console.WriteLine("Tipo de consulta válido.");
}
else
{
    Console.WriteLine("Error: tipo de consulta no válido.");
}
if (ValidarTextoObligatorio(nombre))
{
    Console.WriteLine("Nombre válido.");
}
else
{
    Console.WriteLine("Error: el nombre es obligatorio.");
}

if (ValidarTextoObligatorio(descripcion))
{
    Console.WriteLine("Descripción válida.");
}
else
{
    Console.WriteLine("Error: la descripción es obligatoria.");
}
string prioridad = CalcularPrioridad(tipoConsulta);
Console.WriteLine($"Prioridad de atención: {prioridad}");
MostrarResumen(codigo, nombre, tipoConsulta, descripcion, prioridad);