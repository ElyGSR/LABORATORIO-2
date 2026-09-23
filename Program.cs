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

Console.WriteLine($"Código: {codigo}");
Console.WriteLine($"Nombre: {nombre}");
Console.WriteLine($"Tipo de consulta: {tipoConsulta}");
Console.WriteLine($"Descripción: {descripcion}");