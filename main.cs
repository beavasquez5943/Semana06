class Principal
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Calcular promedio y clasificar en listas");
        Console.WriteLine("2. Comparar listas de enteros");
        Console.Write("Seleccione opción (1 o 2): ");
        int opcion = int.Parse(Console.ReadLine());

        if (opcion == 1)
            Programa1.Ejecutar();
        else if (opcion == 2)
            Programa2.Ejecutar();
        else
            Console.WriteLine("Opción inválida");
    }
}