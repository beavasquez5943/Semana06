class NodoEntero
{
    public int Dato;
    public NodoEntero Siguiente;

    public NodoEntero(int dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class ListaEnteros
{
    public NodoEntero Inicio;

    public void AgregarInicio(int dato)
    {
        NodoEntero nuevo = new NodoEntero(dato);
        nuevo.Siguiente = Inicio;
        Inicio = nuevo;
    }

    public int Longitud()
    {
        int contador = 0;
        NodoEntero actual = Inicio;
        while (actual != null)
        {
            contador++;
            actual = actual.Siguiente;
        }
        return contador;
    }

    public bool Comparar(ListaEnteros otra)
    {
        NodoEntero a = this.Inicio;
        NodoEntero b = otra.Inicio;

        while (a != null && b != null)
        {
            if (a.Dato != b.Dato)
                return false;
            a = a.Siguiente;
            b = b.Siguiente;
        }

        return a == null && b == null;
    }
}

class Programa2
{
    public static void Ejecutar()
    {
        ListaEnteros lista1 = new ListaEnteros();
        ListaEnteros lista2 = new ListaEnteros();

        Console.Write("Ingrese cantidad de datos para la lista 1: ");
        int n1 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n1; i++)
        {
            Console.Write("Dato #" + (i + 1) + ": ");
            int dato = int.Parse(Console.ReadLine());
            lista1.AgregarInicio(dato);
        }

        Console.Write("Ingrese cantidad de datos para la lista 2: ");
        int n2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n2; i++)
        {
            Console.Write("Dato #" + (i + 1) + ": ");
            int dato = int.Parse(Console.ReadLine());
            lista2.AgregarInicio(dato);
        }

        if (lista1.Longitud() == lista2.Longitud())
        {
            if (lista1.Comparar(lista2))
                Console.WriteLine("Las listas son iguales en tamaño y contenido.");
            else
                Console.WriteLine("Las listas son iguales en tamaño, pero no en contenido.");
        }
        else
        {
            Console.WriteLine("Las listas no tienen el mismo tamaño ni contenido.");
        }
    }
}