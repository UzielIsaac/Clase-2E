// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main()
    {
        // Este programa calcula la calificación total de un alumno basado en tres actividades.

        // Se piden las calificaciones de las tres actividades: prácticas (pr), examen (ex) y tareas (ta).
        Console.Write("Ingresa la calificación de las prácticas: ");
        double pr = Convert.ToDouble(Console.ReadLine());  // Esta línea recibe la calificación de las prácticas.

        Console.Write("Ingresa la calificación del examen: ");
        double ex = Convert.ToDouble(Console.ReadLine());  // Esta línea recibe la calificación del examen.

        Console.Write("Ingresa la calificación de las tareas: ");
        double ta = Convert.ToDouble(Console.ReadLine());  // Esta línea recibe la calificación de las tareas.

        // Se calcula la calificación total utilizando los porcentajes correspondientes para cada actividad.
        // 55% para las prácticas, 30% para el examen y 15% para las tareas.

        double calificacion_total = (pr * 0.55) + (ex * 0.30) + (ta * 0.15);  // Esta fórmula calcula la calificación total.

        // El resultado se muestra en pantalla.
        Console.WriteLine("La calificación total del alumno es: " + calificacion_total);  // Esta línea muestra la calificación total.
    }
}
