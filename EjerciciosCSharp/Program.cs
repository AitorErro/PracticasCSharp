using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


//PROBANDO CAMBIOS CON GITHUB


//MAS COMENTSSSSSSSSS

//PRIMER CAMBIO DESDE CASA

namespace EjerciciosCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el número de ejercicio: ");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("1-Ejercicio 1 (vacío)");
            Console.WriteLine("2-Ejercicio 2");
            Console.WriteLine("3-Ejercicio 3");
            Console.WriteLine("4-Ejercicio 4");
            Console.WriteLine("5-Ejercicio 5");
            Console.WriteLine("6-Ejercicio 6");
            Console.WriteLine("7-Ejercicio 7");
            Console.WriteLine("8-Ejercicio 8");
            Console.WriteLine("9-Ejercicio 9");
            Console.WriteLine("10-Ejercicio 10");
            Console.WriteLine("11-Ejercicio 11");
            Console.WriteLine("12-Ejercicio 12");
            Console.WriteLine("Introduzca 0 para salir.");

            //Definir la respuesta (en string), parsear a int, y por cada respuesta llamar al ejercicio en cuestión
            String respuesta = Console.ReadLine();
            int respuestaInt = Int32.Parse(respuesta);
            switch (respuestaInt)
            {
                case 1:
                    Console.WriteLine("Ejercicio vacío");
                    break;
                case 2:
                    Program.Ejercicio2();
                    break;
                case 3:
                    Program.Ejercicio3();
                    break;
                case 4:
                    Program.Ejercicio4();
                    break;
                case 5:
                    Program.Ejercicio5();
                    break;
                case 6:
                    Program.Ejercicio6();
                    break;
                case 7:
                    Program.Ejercicio7();
                    break;
                case 8:
                    Program.Ejercicio8();
                    break;
                case 9:
                    Program.Ejercicio9();
                    break;
                case 10:
                    Program.Ejercicio10();
                    break;
                case 11:
                    Program.Ejercicio11();
                    break;
                case 12:
                    Program.Ejercicio12();
                    break;
                case 0:
                    System.Environment.Exit(1);
                    break;
                default:
                    Console.WriteLine("No se ha encontrado el ejercicio");
                    break;
            }

            Console.ReadLine();

            Program.Main(args);
        }

        static void Ejercicio1()
        {
            Console.WriteLine("Este ejercicio no está disponible");

        }

        static void Ejercicio2() {
            Console.WriteLine("EJERCICIO 2: ESCRIBIR EL NÚMERO MENOR");

            try
            {
                //Definir las variables
                Console.WriteLine("Introducir NUMERO-1: ");
                //string num1 = Console.ReadLine();
                //int n1 = Int32.Parse(num1);
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introducir NUMERO-2: ");
                //string num2 = Console.ReadLine();
                //int n2 = Int32.Parse(num2);
                int n2 = Convert.ToInt32(Console.ReadLine());

                //Lógica que se aplica para saber cual de los números es menos
                if (n1 > n2)
                {
                    Console.WriteLine("De los números " + n1 + " y " + n2 + " el MENOR es: " + n2);

                }
                else if (n1 < n2)
                {
                    Console.WriteLine("De los números " + n1 + " y " + n2 + " el MENOR es: " + n1);
                }
                else
                {
                    Console.WriteLine("Los números " + n1 + " y " + n2 + " tienen el mismo valor");
                }
            }
            catch
            {
                Console.WriteLine("Valores introducidos no válidos");
            }
        }

        static void Ejercicio3()
        {
            Console.WriteLine("EJERCICIO 3: ESCRIBIR EL NÚMERO MAYOR");

            try
            { 
                //Definir las variables
                Console.WriteLine("Introducir NUMERO-1: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introducir NUMERO-2: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introducir NUMERO-3: ");
                int n3 = Convert.ToInt32(Console.ReadLine());

                //Logica que determina cual es el mayor
                if (n1 > n2 && n1 > n3)
                {
                    Console.WriteLine("De los números " + n1 + ", " + n2 + " y " + n3 + " el MAYOR es: " + n1);
                }
                else
                {
                    if (n2 > n1 && n2 > n3)
                    {
                        Console.WriteLine("De los números " + n1 + ", " + n2 + " y " + n3 + " el MAYOR es: " + n2);
                    }
                    else
                    {
                        if (n3 > n1 && n3 > n2)
                        {
                            Console.WriteLine("De los números " + n1 + ", " + n2 + " y " + n3 + " el MAYOR es: " + n3);
                        }
                        else
                        {
                            Console.WriteLine("Los números " + n1 + ", " + n2 + " y " + n3 + " tienen el mismo valor");
                        }
                    }
                }
            }
            catch
            {
                Console.WriteLine("Valores introducidos no válidos");
            }
            
        }

        static void Ejercicio4()
        {
            Console.WriteLine("EJERCICIO 4: ESCRIBIR 3 NÚMEROS EN ORDEN DECRECIENTE");

            try
            {
                //Definir las variables
                Console.WriteLine("Introducir NUMERO-1: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introducir NUMERO-2: ");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introducir NUMERO-3: ");
                int n3 = Convert.ToInt32(Console.ReadLine());
                
                //Logica que identifica los números para mostrarlos en orden decreciente
                if (n1 > n2 && n1 > n3)
                {
                    if (n2 > n3)
                    {
                        Console.WriteLine("Orden decreciente: " + n1 + " > " + n2 + " > " + n3);
                    }
                    else if (n2 < n3)
                    {
                        Console.WriteLine("Orden decreciente: " + n1 + " > " + n3 + " > " + n2);
                    }
                    else
                    {
                        Console.WriteLine("Orden decreciente: " + n1 + " > " + n2 + " = " + n3 + " (dos de los números son iguales)");
                    }
                }
                else if (n2 > n1 && n2 > n3)
                {
                    if (n1 > n3)
                    {
                        Console.WriteLine("Orden decreciente: " + n2 + " > " + n1 + " > " + n3);
                    }
                    else if (n1 < n3)
                    {
                        Console.WriteLine("Orden decreciente: " + n2 + " > " + n3 + " > " + n1);
                    }
                    else
                    {
                        Console.WriteLine("Orden decreciente: " + n2 + " > " + n1 + " = " + n3 + " (dos de los números son iguales)");
                    }
                }
                else if (n3 > n1 && n3 > n2)
                {
                    if (n1 > n2)
                    {
                        Console.WriteLine("Orden decreciente: " + n3 + " > " + n1 + " > " + n2);
                    }
                    else if (n1 < n2)
                    {
                        Console.WriteLine("Orden decreciente: " + n3 + " > " + n2 + " > " + n1);
                    }
                    else
                    {
                        Console.WriteLine("Orden decreciente: " + n3 + " > " + n1 + " = " + n2 + " (dos de los números son iguales)");
                    }
                }
                else if (n1 == n2 && n1 > n3)
                {
                    Console.WriteLine("Orden decreciente: " + n1 + " = " + n2 + " > " + n3 + " (dos de los números son iguales)");
                }
                else if (n1 == n3 && n1 > n2)
                {
                    Console.WriteLine("Orden decreciente: " + n1 + " = " + n3 + " > " + n2 + " (dos de los números son iguales)");
                }
                else if (n2 == n3 && n2 > n1)
                {
                    Console.WriteLine("Orden decreciente: " + n2 + " = " + n3 + " > " + n1 + " (dos de los números son iguales)");
                }
                else //if (n1 == n2 && n1 == n3)
                {
                    Console.WriteLine("Los tres números introducidos tienen el mismo valor: " + n1);
                }
            }
            catch
            {
                Console.WriteLine("Valores introducidos no válidos");
            }
        }

        static void Ejercicio5()
        {
            Console.WriteLine("EJERCICIO 5: EJERCICIO TEÓRICO");
        }

        static void Ejercicio6()
        {
            Console.WriteLine("EJERCICIO 6: EJERCICIO TEÓRDICO");
        }

        static void Ejercicio7()
        {
            Console.WriteLine("EJERCICIO 7: LEER NOTA Y ESCRIBIR EVALUACIÓN DE LA MISMA");

            try
            { 
                //definir la variable nota
                Console.WriteLine("Introducir nota (0-10): ");
                int nota = Convert.ToInt32(Console.ReadLine());
                string evaluacion = "";
                //Lógica que determina la evaluación de la nota
                if (nota < 5)
                {
                    evaluacion = "SUSPENSO";
                }
                else if (nota >= 5 && nota < 7)
                {
                    evaluacion = "APROBADO";
                }
                else if (nota >= 7 && nota <= 8)
                {
                    evaluacion = "NOTABLE";
                }
                else if (nota >= 9 && nota < 10)
                {
                    evaluacion = "SOBRESALIENTE";
                }
                else if (nota == 10)
                {
                    evaluacion = "MATRÍCULA DE HONOR";
                }
                else
                {
                    Console.WriteLine("El valor introducido no es válido");
                    evaluacion = "NULA";
                }

                Console.WriteLine("Nota: " + nota + ". Evaluación: " + evaluacion);

            }
            catch
            {
                Console.WriteLine("Valor introducido no válido");
            }
        }

        static void Ejercicio8()
        {
            Console.WriteLine("EJERCICIO 8: LEER DOS NÚMEROS Y DECIR SI UNO ES MÚLTIPLO DEL OTRO");

            try
            {
                //definir las variables de los dos numeros (n1 y n2)
                Console.WriteLine("Introduzca el primer numero: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduzca el segundo numero: ");
                int n2 = Convert.ToInt32(Console.ReadLine());

                if (n1 % n2 == 0)
                {
                    Console.WriteLine(n1 + " ES MULTIPLO de " + n2);
                }
                else if (n2 % n1 == 0)
                {
                    Console.WriteLine(n2 + " ES MULTIPLO de " + n1);
                }
                else
                {
                    if (n1 > n2)
                    {
                        Console.WriteLine( n1 + " no es múltiplo de " + n2);
                    }
                    else
                    {
                        Console.WriteLine(n2 + " no es múltiplo de " + n1);
                    }
                }

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio9()
        {
            Console.WriteLine("EJERCICIO 9: LEER DÍA, MES Y AÑO (NÚMEROS) Y COMPROBAR SI ES FECHA CORRECTA (TENIENDO EN CUENTA AÑOS BISIESTOS");

            try
            {
                //Definir tres variables (números) los cuales representaran una fecha
                Console.WriteLine("Inserte una fecha: ");
                Console.WriteLine("Día: (1-31)");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mes: (1-12)");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Año: (0-9999)");
                int n3 = Convert.ToInt32(Console.ReadLine());

                //Lógica que determina si la fecha es correcta o no, con un TRY CATCH
                try
                {
                    DateTime fecha = new DateTime(n3, n2, n1);
                    Console.WriteLine("La fecha introducida es válida: " + fecha + ".");
                }
                catch
                {
                    Console.WriteLine("La fecha introducida no es una fecha válida (" + n1 + "/" + n2 + "/" + n3 + ").");
                }
    }
            catch
            {
                Console.WriteLine("Error");
            }
        }
        
        static void Ejercicio10()
        {
            Console.WriteLine("EJERCICIO 10: LEER DÍA, MES Y AÑO (NÚMEROS) Y COMPROBAR SI ES FECHA CORRECTA UTILIZANDO SWITCH");

            try
            {
                //Definir tres variables (números) los cuales representaran una fecha
                Console.WriteLine("Inserte una fecha: ");
                Console.WriteLine("Día: (1-31)");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Mes: (1-12)");
                int n2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Año: (0-9999)");
                int n3 = Convert.ToInt32(Console.ReadLine());

                //Lógica que determina si la fecha es correcta o no, con un SWITCH
                DateTime fecha = new DateTime(n3, n2, n1);
                bool var1 = DateTime.IsLeapYear(n3);
                switch (var1)
                {
                    case true:
                        Console.WriteLine("Año bisiesto");
                        Console.WriteLine("Fecha introducida correcta");
                        Console.WriteLine(fecha);
                        break;
                    case false:
                        Console.WriteLine("Año no bisiesto");
                        Console.WriteLine("Fecha introducida correcta");
                        Console.WriteLine(fecha);
                        break;
                    default:
                        Console.WriteLine("Formato incorrecto");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("Fecha no válida");
            }
        }

        static void Ejercicio11()
        {
            Console.WriteLine("EJERCICIO 11: ");

            try
            {

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio12()
        {
            Console.WriteLine("EJERCICIO 12: ");

            try
            {

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }
    }
}
