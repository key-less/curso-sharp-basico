using System;

class Program
{
    static void Main()
    {
        int number;

        Console.Write("Entra un numero del 1 al 99: ");
        number = Convert.ToInt32(Console.ReadLine());

        if (number >= 1 && number <= 9)
        {
            Console.WriteLine("El numero tiene un solo digito.");
        }
        else if (number >= 10 && number <= 99)
        {
            Console.WriteLine("El numero tiene dos digitos.");
        }
        else
        {
            Console.WriteLine("Dato incorrecto.");
        }
    }
}