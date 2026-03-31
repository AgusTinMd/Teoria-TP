using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombre = Console.ReadLine();

        double[] notas = new double[3];

        Console.Write("Ingrese nota 1: ");
        notas[0] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese nota 2: ");
        notas[1] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese nota 3: ");
        notas[2] = Convert.ToDouble(Console.ReadLine());

        double promedio = CalcularPromedio(notas);

        string estado;
        if (promedio >= 6)
        {
            estado = "aprobado/a";
        }
        else
        {
            estado = "reprobado/a";
        }

        Console.WriteLine($"{nombre} tiene un promedio de {Math.Round(promedio, 2)} y está {estado}");
    }

    static double CalcularPromedio(double[] notas)
    {
        double suma = 0;
        foreach (double nota in notas)
        {
            suma += nota;
        }
        return suma / notas.Length;
    }
}