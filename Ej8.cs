using System;
using System.Collections.Generic;

class Nodo
{
    public double Dato;
    public Nodo Siguiente;

    public Nodo(double dato)
    {
        Dato = dato;
        Siguiente = null;
    }
}

class Lista
{
    public Nodo Inicio;

    public void Agregar(double dato)
    {
        Nodo nuevo = new Nodo(dato);
        if (Inicio == null)
            Inicio = nuevo;
        else
        {
            Nodo actual = Inicio;
            while (actual.Siguiente != null)
                actual = actual.Siguiente;
            actual.Siguiente = nuevo;
        }
    }

    public double CalcularPromedio()
    {
        int count = 0;
        double suma = 0;
        Nodo actual = Inicio;
        while (actual != null)
        {
            suma += actual.Dato;
            count++;
            actual = actual.Siguiente;
        }
        return (count == 0) ? 0 : suma / count;
    }

    public void Mostrar()
    {
        Nodo actual = Inicio;
        while (actual != null)
        {
            Console.Write(actual.Dato + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }
}

class Programa1
{
    public static void Ejecutar()
    {
        Lista listaPrincipal = new Lista();
        Lista listaMenoresIgual = new Lista();
        Lista listaMayores = new Lista();

        Console.Write("Ingrese la cantidad de datos: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.Write("Ingrese el dato #" + (i + 1) + ": ");
            double dato = double.Parse(Console.ReadLine());
            listaPrincipal.Agregar(dato);
        }

        double promedio = listaPrincipal.CalcularPromedio();

        Nodo actual = listaPrincipal.Inicio;
        while (actual != null)
        {
            if (actual.Dato <= promedio)
                listaMenoresIgual.Agregar(actual.Dato);
            else
                listaMayores.Agregar(actual.Dato);
            actual = actual.Siguiente;
        }

        Console.WriteLine("\nLista Principal:");
        listaPrincipal.Mostrar();
        Console.WriteLine("Promedio: " + promedio);
        Console.WriteLine("Datos <= Promedio:");
        listaMenoresIgual.Mostrar();
        Console.WriteLine("Datos > Promedio:");
        listaMayores.Mostrar();
    }
}