using System;

class Program
{
    static void Main()
    {
        int num1, num2;

        Console.Write("Entra un Primer Numero: "); 
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Entra un Segundo Numero: "); 
        num2 = Convert.ToInt32(Console.ReadLine());

        if (num1 > num2) { Console.WriteLine("La suma es: " + (num1 + num2)); 
            Console.WriteLine("La diferencia es: " + (num1 - num2)); 
        } else { Console.WriteLine("El producto es: " + (num1 * num2)); 
            Console.WriteLine("La division es: " + (num1 / (double)num2)); }
    }
}
