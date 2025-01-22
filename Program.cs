// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Este programa lee e imprime una serie de números distintos de cero.
        // La función termina cuando se introduce un valor cero, que no se imprime.
        // También muestra la cantidad de números ingresados (sin contar el cero).

        int numero; // Esta variable almacena el número ingresado por el usuario.
        int contador = 0; // Esta variable cuenta cuántos números válidos se han leído.

        Console.WriteLine("Ingresa números distintos de cero (termina con 0):");
        
        do
        {
            // Se solicita al usuario que ingrese un número.
            Console.Write("Ingresa un número: ");
            numero = Convert.ToInt32(Console.ReadLine()); // Convierte el valor ingresado a un entero.

            if (numero != 0) // Esta condición verifica que el número no sea cero.
            {
                Console.WriteLine("Número ingresado: " + numero); // Imprime el número ingresado.
                contador++; // Incrementa el contador porque el número es válido.
            }
        } while (numero != 0); // Este ciclo continúa mientras el número sea distinto de cero.

        // Se muestra la cantidad de números válidos leídos.
        Console.WriteLine("Cantidad de números ingresados: " + contador); // Imprime el número total de entradas válidas.
    }
}