using System;

class Program
{
    static void Main()
    {
        double nota1, nota2, nota3;

        Console.Write("entra la primera nota: ");
        nota1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("entra la segunda nota ");
        nota2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("entra la tercera nota: ");
        nota3 = Convert.ToDouble(Console.ReadLine());

        double promedio = (nota1 + nota2 + nota3) / 3;

        if (promedio >= 70)
        {
            Console.WriteLine("Promovido");
        }
        else
        {
            Console.WriteLine("Desaprobado");
        }
    }
}
