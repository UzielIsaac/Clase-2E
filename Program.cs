using System;
using Triangulos.Data; // para ser una clase padre o que no lo ocuparemos 

namespace areaTriangulos
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; } //propiedades de nuestra clase 
        public double LadoC { get; set; }

        public Triangulo(double ladoA, double ladoB, double ladoC) // nuestros objetos, publicas para poder usarlas sin restrincciones 
        {
            LadoA = ladoA;
            LadoB = ladoB;
            LadoC = ladoC;
        }

        public bool EsCorrecto()
        {
            return (LadoA + LadoB > LadoC) && // el && nos sirve como operador AND para nuestro operador booleano
                   (LadoA + LadoC > LadoB) &&
                   (LadoB + LadoC > LadoA); // nuestro punto y como sirve para poder cerrarlo 
        }

        private double CalcularSemiPerimetro() // ponemos el private para que solo usarlo dentro de esta clase , funcion dada por chatgpt, utilidad: se utiliza para mantener el control y proteger los datos 
        {
            return (LadoA + LadoB + LadoC) / 2; //metodo para calcular el semiperimetro
        }

        public double CalcularArea()
        {
            double p = CalcularSemiPerimetro();
            return Math.Sqrt(p * (p - LadoA) * (p - LadoB) * (p - LadoC)); //uso del Math.Sqrt, su uso es para sacar raiz cuadrada 
        }

        public string QuetipoDeTrianguloEs() // el uso string se debe que son solo cadena de texto y es lo que se imprimen 
        {
            if (LadoA == LadoB && LadoB == LadoC)
            {
                return "Equilatero";
            }
            else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC) // || significa "o". Aquí se está preguntando:
                                                                         //¿Son iguales LadoA y LadoB?
                                                                         //¿O son iguales LadoA y LadoC?
                                                                         //¿O son iguales LadoB y LadoC?
            {
                return "Isosceles";
            }
            else
            {
                return "Escaleno"; //Si ningún lado es igual a otro, el triángulo es Escaleno.
            }
        }
    }

    class program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Calculadora de áreas y tipos de triángulo uwu");
                Console.Write("Ingresa el lado A: ");
                double ladoA = double.Parse(Console.ReadLine()); // de aquí es para solicitar datos al usuario una vez hacer las diferencias de triángulos 

                Console.Write("Ingresa el lado B: ");
                double ladoB = double.Parse(Console.ReadLine());

                Console.Write("Ingresa el lado C: ");
                double ladoC = double.Parse(Console.ReadLine());

                // generamos un objeto 
                Triangulo triangulo = new Triangulo(ladoA, ladoB, ladoC); // nombramos la clase para generar un nuevo objeto 

                if (!triangulo.EsCorrecto())
                {
                    Console.WriteLine("Los lados ingresados no forman un triángulo "); //se nos arroja si no conforman un triángulo 
                }
                else
                {
                    double area = triangulo.CalcularArea();
                    Console.WriteLine($"El área del triángulo es: {area:F2} ");

                    string tipo = triangulo.QuetipoDeTrianguloEs(); // Corrección del nombre del método
                    Console.WriteLine($"El triángulo es: {tipo}");
                }

                Console.Write("¿Quieres calcular otro triángulo? (sii/nop): ");
                string respuesta = Console.ReadLine();

                if (respuesta.ToLower() != "sii") // Corrección de ToLower
                {
                    Console.WriteLine("Lito");
                    break; // final de nuestro programa 
                }
            }
        }
    }
}
// Errores corregidos:
//Constructor de la clase Triangulo: Cambié las variables del constructor para diferenciar entre parámetros y propiedades. Usé nombres como ladoA en lugar de LadoA.

//Condicional de semiperímetro: Arreglé la lógica en el método EsCorrecto para que valide correctamente los lados.

//Método QuetipoDeTrianguloEs: Corregí el nombre que estaba mal referenciado como DeterminarTipo. Ahora usa QuetipoDeTrianguloEs.

//Llamada al método ToLower: Había un error tipográfico en ToLowe. Lo cambié por ToLower.

//Estructura del while: Arreglé el cierre del bucle while.
// estos son errores que me corrigio chatgpt
