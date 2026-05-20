/*
SEMANA 2: 18 - 20 DE MAYO 2026
JOSEPH MAURICIO MONDRAGON MORENO
SISTEMAS COMPUTACIONALES 
MATUTINO A
SCO6MA116
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana2_JMMM
{
    internal class Program
    {
        // Metodo para generar un salto de linea
        static void SaltoLinea()
        {
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Variables principales del programa
            string nombreUsuario;
            int edadUsuario = 0;

            double primerNumero, segundoNumero = 0;
            double suma, resta, multiplicacion, division;

            // Encabezado e instrucciones del programa
            Console.WriteLine("Variables y operadores en C#");
            SaltoLinea();

            Console.WriteLine("Semana 2 - Actividad.");
            SaltoLinea();

            Console.WriteLine("Desarrollar un programa en consola que:");
            SaltoLinea();

            Console.WriteLine("1. Solicite nombre y edad.");
            Console.WriteLine("2. Realice operaciones básicas (+, -, *, /)");
            Console.WriteLine("3. Muestre resultados en pantalla.");
            SaltoLinea();

            Console.WriteLine("*******************************************");
            SaltoLinea();

            // Solicitud de nombre y edad del usuario
            Console.WriteLine("1. Solicitud de nombre y edad.");
            SaltoLinea();

            Console.WriteLine("Ingresa tu nombre:");
            nombreUsuario = Console.ReadLine();
            SaltoLinea();

            Console.WriteLine("Ingresa tu edad:");

            // Validacion de que la edad sea numerica y este en un rango permitido
            while (!int.TryParse(Console.ReadLine(), out edadUsuario)
                || edadUsuario <= 0
                || edadUsuario >= 120)
            {
                SaltoLinea();

                Console.WriteLine("¡ERROR!");
                Console.WriteLine("Ingresa una edad valida.");
                SaltoLinea();

                Console.Write("Ingresa nuevamente tu edad: ");
            }
            SaltoLinea();

            // Muestra los datos ingresados
            Console.WriteLine("Bienvenido " + nombreUsuario + ", tienes " + edadUsuario + " años de edad.");
            SaltoLinea();

            Console.WriteLine("*******************************************");
            SaltoLinea();

            // Solicitud de los numeros para las operaciones matematicas
            Console.WriteLine("2. Operaciones básicas (+, -, *, /)");
            SaltoLinea();

            Console.WriteLine("Operaciones matematicas basicas.");
            SaltoLinea();

            Console.Write("Ingresa el primer numero: ");

            // Validacion de que el numero sea correcto y diferente de cero
            while (!double.TryParse(Console.ReadLine(), out primerNumero)
                || primerNumero == 0)
            {
                SaltoLinea();

                Console.WriteLine("¡ERROR!");
                Console.WriteLine("Ingresa un numero diferente de cero.");
                SaltoLinea();

                Console.Write("Ingresa nuevamente el primer numero: ");

            }

            SaltoLinea();
            Console.Write("Ingresa el segundo numero: ");

            // Validacion que el numero sea correcto y diferente de cero
            while (!double.TryParse(Console.ReadLine(), out segundoNumero)
                || segundoNumero == 0)
            {
                SaltoLinea();

                Console.WriteLine("¡ERROR!");
                Console.WriteLine("Ingresa un numero diferente de cero.");
                SaltoLinea();

                Console.Write("Ingresa nuevamente el segundo numero: ");
            }
            SaltoLinea();

            // Realizacion de las operaciones matematicas
            suma = primerNumero + segundoNumero;
            resta = primerNumero - segundoNumero;
            multiplicacion = primerNumero * segundoNumero;
            division = primerNumero / segundoNumero;

            // Mostrar los resultados
            Console.WriteLine("Resultados:");
            SaltoLinea();

            Console.WriteLine("Suma: " + suma);
            Console.WriteLine("Resta: " + resta);
            Console.WriteLine("Multiplicacion: " + multiplicacion);

            // Muestra la division con 2 decimales
            Console.WriteLine("Division: " + division.ToString("0.00"));
            SaltoLinea();

            // Mantiene la consola abierta hasta que el usuario presione una tecla
            Console.WriteLine("Presione cualquier tecla para finalizar...");
            Console.ReadLine();
        }
    }
}