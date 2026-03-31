using System;

class Persona 
{
    public string Nombre;

    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    public override string ToString()
    {
        return "Persona";
    }
}

class Estudiante : Persona 
{
    public double[] Notas;

    public Estudiante(string nombre) : base(nombre)
    {
        Notas = new double[3];
    }

    public double CalcularPromedio() 
    {
        double suma = 0;
        foreach (double nota in Notas)
        {
            suma += nota;
        }
        return suma / Notas.Length;
    }

    public override string ToString() => "Estudiante"; 
}

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.Write("Ingrese el nombre del estudiante: ");
            string nombreIngresado = Console.ReadLine();

            Estudiante alumno = new Estudiante(nombreIngresado);

            Console.Write("Ingrese nota 1: ");
            alumno.Notas[0] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nota 2: ");
            alumno.Notas[1] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingrese nota 3: ");
            alumno.Notas[2] = Convert.ToDouble(Console.ReadLine());

            double promedio = alumno.CalcularPromedio();

            string estado;
            if (promedio >= 6) 
            {
                estado = "aprobada";
            }
            else
            {
                estado = "reprobada";
            }

            Console.WriteLine($"{alumno.Nombre} (Tipo: {alumno.ToString()}) tiene un promedio de {Math.Round(promedio, 2)} y está {estado}");

            Console.Write("\n¿Querés ingresar otro estudiante? (s/n): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta != "s")
            {
                continuar = false; 
            }
            
            Console.WriteLine("--------------------------------------------------\n"); 
        }
    }
}