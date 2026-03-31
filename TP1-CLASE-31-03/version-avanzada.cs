using System;

// 1. HERENCIA: Creamos la clase base Persona
class Persona
{
    public string Nombre;

    // Constructor de la clase base
    public Persona(string nombre)
    {
        Nombre = nombre;
    }

    // POLIMORFISMO: Método virtual que permite ser sobrescrito en clases derivadas
    public virtual string ToString()
    {
        return "Persona";
    }
}

// 2. CLASE Y HERENCIA: Estudiante hereda de Persona
class Estudiante : Persona
{
    public double[] Notas;

    // 3. CONSTRUCTOR: Inicializa el nombre usando el constructor de la clase base (Persona)
    public Estudiante(string nombre) : base(nombre)
    {
        // Inicializamos el arreglo para asegurarnos de que tenga espacio para las 3 notas
        Notas = new double[3];
    }

    // 4. MÉTODO DE CLASE: Calcula el promedio usando los datos del propio objeto
    public double CalcularPromedio()
    {
        double suma = 0;
        foreach (double nota in Notas)
        {
            suma += nota;
        }
        return suma / Notas.Length;
    }

    // 5. POLIMORFISMO: Sobrescribimos (override) el método ToString
    public override string ToString()
    {
        return "Estudiante";
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el nombre del estudiante: ");
        string nombreIngresado = Console.ReadLine();

        // Instanciamos el objeto usando el constructor
        Estudiante alumno = new Estudiante(nombreIngresado);

        // Pedimos y asignamos las notas directamente a la propiedad del objeto
        Console.Write("Ingrese nota 1: ");
        alumno.Notas[0] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese nota 2: ");
        alumno.Notas[1] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese nota 3: ");
        alumno.Notas[2] = Convert.ToDouble(Console.ReadLine());

        // Llamamos al método propio del objeto para obtener el promedio
        double promedio = alumno.CalcularPromedio();

        // Determinamos si aprueba o reprueba
        string estado;
        if (promedio >= 6)
        {
            estado = "aprobada";
        }
        else
        {
            estado = "reprobada";
        }

        // Mostramos el resultado. Usamos alumno.ToString() para demostrar el polimorfismo.
        Console.WriteLine($"{alumno.Nombre} (Tipo: {alumno.ToString()}) tiene un promedio de {Math.Round(promedio, 2)} y está {estado}");
    }
}