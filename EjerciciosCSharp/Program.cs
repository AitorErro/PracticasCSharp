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
            Console.WriteLine("13-Ejercicio 13");
            Console.WriteLine("14-Ejercicio 14");
            Console.WriteLine("15-Ejercicio 15");
            Console.WriteLine("16-Ejercicio 16");
            Console.WriteLine("17-Ejercicio 17");
            Console.WriteLine("18-Ejercicio 18");
            Console.WriteLine("19-Ejercicio 19");
            Console.WriteLine("20-Ejercicio 20");
            Console.WriteLine("21-Ejercicio 21");
            Console.WriteLine("22-Ejercicio 22");
            Console.WriteLine("23-Ejercicio 23");
            Console.WriteLine("24-Ejercicio 24");
            Console.WriteLine("25-Ejercicio 25");
            Console.WriteLine("26-Ejercicio 26");
            Console.WriteLine("27-Ejercicio 27");
            Console.WriteLine("28-Ejercicio 28");
            Console.WriteLine("29-Ejercicio 29");
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
                    Ejercicio2();
                    break;
                case 3:
                    Ejercicio3();
                    break;
                case 4:
                    Ejercicio4();
                    break;
                case 5:
                    Ejercicio5();
                    break;
                case 6:
                    Ejercicio6();
                    break;
                case 7:
                    Ejercicio7();
                    break;
                case 8:
                    Ejercicio8();
                    break;
                case 9:
                    Ejercicio9();
                    break;
                case 10:
                    Ejercicio10();
                    break;
                case 11:
                    Ejercicio11();
                    break;
                case 12:
                    Ejercicio12();
                    break;
                case 13:
                    Ejercicio13();
                    break;
                case 14:
                    Ejercicio14();
                    break;
                case 15:
                    Ejercicio15();
                    break;
                case 16:
                    Ejercicio16();
                    break;
                case 17:
                    Ejercicio17();
                    break;
                case 18:
                    Ejercicio18();
                    break;
                case 19:
                    Ejercicio19();
                    break;
                case 20:
                    Ejercicio20();
                    break;
                case 21:
                    Ejercicio21();
                    break;
                case 22:
                    Ejercicio22();
                    break;
                case 23:
                    Ejercicio23();
                    break;
                case 24:
                    Ejercicio24();
                    break;
                case 25:
                    Ejercicio25();
                    break;
                case 26:
                    Ejercicio26();
                    break;
                case 27:
                    Ejercicio27();
                    break;
                case 28:
                    Ejercicio28();
                    break;
                case 29:
                    Ejercicio29();
                    break;
                case 0:
                    Environment.Exit(1);
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
                Console.WriteLine("Año: (1-9999)");
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

        //Punto de fusion

        static void Ejercicio11()
        {
            Console.WriteLine("EJERCICIO 11: ESCRIBIR CONDICIONES CON LAS VARIABLES v1, v2 y v3");

            try
            {
                //Definir las variable v1, v2 y v3 como números enteros (int)
                Console.WriteLine("Escriba el primer valor: ");
                int v1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el segundo valor: ");
                int v2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el tercer valor: ");
                int v3 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Valores introducidos: ");
                Console.WriteLine($"Valor 1: {v1}");
                Console.WriteLine($"Valor 2: {v2}");
                Console.WriteLine($"Valor 3: {v3}");

                //a) Todas las variables son 0
                if (v1 == 0 && v2 == 0 && v3 == 0)
                {
                    Console.WriteLine("Todas las variables son 0.");
                }
                //b) Todas las variables son positivas
                if (v1 > 0 && v2 > 0 && v3 > 0)
                {
                    Console.WriteLine("Todas las variables son positivas.");
                    //c) Todas las variables tienen el mismo signo
                    Console.WriteLine("Todas las variables tienen el mismo signo (+).");
                }
                if (v1 < 0 && v2 < 0 && v3 < 0)
                {
                    Console.WriteLine("Todas las variables tienen el mismo signo (-).");
                }
                //d) Todos los valores son distintos
                if (v1 != v2 && v1 != v3 && v2 != v3)
                {
                    Console.WriteLine("Todas los valores son distintos.");
                }
                //e) Dos de sus valores coinciden
                if (v1 == v2 || v1 == v3 || v2 == v3)
                {
                    Console.WriteLine("Dos de sus valores coinciden.");
                }
                //f) Como dos de sus valores coinciden
                if (v1 == v2 | v1 == v2 | v2 == v3)
                {
                    Console.WriteLine("Dos máximo de sus valores coinciden.");
                }
                //g) El valor de v2 está comprendido entre los de v1 y v3
                if (v1 < v2 && v2 < v3 || v1 > v2 && v2 > v3)
                {
                    Console.WriteLine("El valor de v2 está comprendido entre los de v1 y v3.");
                }

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio12()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {
                //Definir las variables mes y año
                Console.WriteLine("Escriba el número de mes: (1-12)");
                int mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Escriba el número de año: (1-9999)");
                int anio = Convert.ToInt32(Console.ReadLine());

                //Asignar un nombre en castellano al mes introducido por valor númerico, para facilitar la compresión al usuario
                string nombreMes = "";
                switch (mes)
                {
                    case 1:
                        nombreMes = "Enero";
                        break;
                    case 2:
                        nombreMes = "Febrero";
                        break;
                    case 3:
                        nombreMes = "Marzo";
                        break;
                    case 4:
                        nombreMes = "Abril";
                        break;
                    case 5:
                        nombreMes = "Mayo";
                        break;
                    case 6:
                        nombreMes = "Junio";
                        break;
                    case 7:
                        nombreMes = "Julio";
                        break;
                    case 8:
                        nombreMes = "Agosto";
                        break;
                    case 9:
                        nombreMes = "Septiembre";
                        break;
                    case 10:
                        nombreMes = "Octubre";
                        break;
                    case 11:
                        nombreMes = "Noviembre";
                        break;
                    case 12:
                        nombreMes = "Diciembre";
                        break;
                    default:
                        Console.WriteLine("El mes introducido no es correcto.");
                        break;
                }

                //Lógica para determinar cuantos días tiene el año guardada en la variable dias
                int diasDelMes = DateTime.DaysInMonth(anio, mes);

                Console.WriteLine($"El mes de {nombreMes} de {anio} tiene {diasDelMes} días.");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio13()
        {
            Console.WriteLine("EJERCICIO 12: Dado un número decir si es primo");

            try
            {
                //Definir variables
                int a = 0, i, n;
                Console.WriteLine("Introduzca un número: ");
                n = Convert.ToInt32(Console.ReadLine());

                for (i = 1; i < (n + 1); i++)
                {
                    if (n % i == 0)
                    {
                        a++;
                    }
                }
                if (a!=2)
                {
                    Console.WriteLine($"{n} NO es un número Primo.");
                }
                else
                {
                    Console.WriteLine($"{n} SÍ es un número Primo.");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio14()
        {
            Console.WriteLine("EJERCICIO 14: ESCRIBIR LOS 50 PRIMEROS NÚMEROS PRIMOS");

            try
            {
                //Asignar variables
                int num, i, n = 4, cont = 2;
                string cad = "";
                Console.WriteLine("Escriba la cantidad (X) de números primos que desea visualizar (se visualizarán los primeros X): ");
                num = Convert.ToInt32(Console.ReadLine());

                //Lógica que determina la cantidad de la variable num de los primeros números primos
                if (num > 2)
                {
                    cad = "2 - 3";
                    while (cont < num)
                    {
                        i = 2;
                        while (i <= n)
                        {
                            if (i == n)
                            {
                                cad = cad + " - " + Convert.ToString(n);
                                cont = cont + 1;
                            }
                            else
                            {
                                if (n % i == 0)
                                {
                                    i = n;
                                }
                            }
                            i = i + 1;
                        }
                        n = n + 1;
                    }
                    Console.WriteLine(cad);
                }
                else
                {
                    if (num > 0)
                    {
                        if (num == 1)
                        {
                            Console.WriteLine("Es primo 2");
                        }
                        else
                        {
                            Console.WriteLine("Es primo 2, 3");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inserte números positivos");
                    }
                }

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio15()
        {
            Console.WriteLine("EJERCICIO 15: Dados dos números enteros, realizar el algoritmo que calcule el " +
                "cociente y el resto(sin utilizar las operaciones de cociente y resto en Java, esto es, / y %)");

            try
            {
                int Dividendo, Divisor, p = 1, q = 0;
                Console.WriteLine("Ingresa Dividendo");
                Dividendo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Ingresa Divisor");
                Divisor = Convert.ToInt16(Console.ReadLine());
                if (Dividendo >= Divisor)
                {
                    while ((Dividendo - Divisor) >= q)
                    {
                        q = Divisor * p;
                        p++;
                    }
                    Console.WriteLine("El cociente es " + (p - 1) + " y el resto es " + ((Dividendo - q)));
                }
                else
                {
                    Console.WriteLine("El denominador debe ser menor");
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio16()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio17()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio18()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio19()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio20()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio21()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio22()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio23()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio24()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio25()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio26()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio27()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio28()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

            try
            {



            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio29()
        {
            Console.WriteLine("EJERCICIO 12: Leer número de mes y año y decir el número de días que tiene ese mes");

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
