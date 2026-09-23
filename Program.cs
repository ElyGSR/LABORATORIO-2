const int LONGITUD_MINIMA_CODIGO = 6;

static bool ValidarCodigoEstudiante(string codigox)
{
    if (codigox.Length < LONGITUD_MINIMA_CODIGO)
    {
        return false;
    }
    return true;
}
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
Console.WriteLine($"Código: {codigo}");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Tipo de consulta: {tipoConsulta}");
Console.WriteLine($"Descripción: {descripcion}");