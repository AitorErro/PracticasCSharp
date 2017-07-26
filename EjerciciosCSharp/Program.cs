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

            Console.WriteLine("Pulse cualquier tecla para volver al menú principal");
            Console.ReadKey();

            Main(args);
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
                //Definiendo las variables
                int Dividendo, Divisor, p = 1, q = 0;
                Console.WriteLine("Escriba el Dividendo");
                Dividendo = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("Escriba el Divisor");
                Divisor = Convert.ToInt16(Console.ReadLine());

                //Lógica del ejercicio
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
            Console.WriteLine("EJERCICIO 16: Leer una lista de números por teclado (hasta que se lea el 0) y " +
                "calcular la suma y la media entera de todos ellos");

            try
            {
                //Definiendo variables
                int cont = 0;
                int suma = 0;
                int media = 0;
                Console.WriteLine("Escriba un número para empezar la suma: ");
                int n = Convert.ToInt32(Console.ReadLine());

                //Lógica del ejercicio
                while (n != 0)
                {
                    cont++;
                    suma = suma + n;

                    Console.WriteLine("Introduzca siguiente número (pulse 0 para salir): ");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                media = suma / cont;

                Console.WriteLine($"La SUMA de todos los números introducidos es: {suma}");
                Console.WriteLine($"La MEDIA de todos los números introducidos es: {media}");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio17()
        {
            Console.WriteLine("EJERCICIO 17: ");

            try
            {
                //Definiendo variables
                int cont = 1;
                int min = 0;
                int max = 0;
                Console.WriteLine("Escriba un número para empezar la lista: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string cad = "Números introducidos: ";
                
                //Lógica del ejercicio
                while (cont <= 50 && n != 0)
                {
                    cont++;
                    int resta = 0;
                    if (n > max)
                    {
                        max = n;
                    }
                    if (n < min)
                    {
                        min = n;
                    }
                    cad = cad + Convert.ToString(n) + " - ";
                    resta = 51 - cont;
                    Console.WriteLine("Continuar con la lista: (" + resta +" restantes) - Pulse 0 para salir");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                if (cont > 50)
                {
                    Console.WriteLine("¡¡¡Se ha superado el límite de números (50)!!!");
                }

                Console.WriteLine(cad);
                Console.WriteLine("Número máximo: " + max);
                Console.WriteLine("Número mínimo: " + min);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio18()
        {
            Console.WriteLine("EJERCICIO 18: MODIFICAR EL ALGORITMO ANTERIOR PARA QUE ADEMÁS CALCULE EL VALOR MEDIO ENTERO");

            try
            {
                //Definiendo variables
                int cont = 1;
                int min = 0;
                int max = 0;
                int suma = 0;
                int media = 0;
                Console.WriteLine("Escriba un número para empezar la lista: ");
                int n = Convert.ToInt32(Console.ReadLine());
                string cad = "Números introducidos: ";

                //Lógica del ejercicio
                while (cont <= 50 && n != 0)
                {
                    cont++;
                    int resta = 0;
                    if (n > max)
                    {
                        max = n;
                    }
                    if (n < min)
                    {
                        min = n;
                    }
                    suma = suma + n;
                    cad = cad + Convert.ToString(n) + " - ";
                    resta = 51 - cont;
                    Console.WriteLine("Continuar con la lista: (" + resta + " restantes) - Pulse 0 para salir");
                    n = Convert.ToInt32(Console.ReadLine());
                }
                if (cont > 50)
                {
                    Console.WriteLine("¡¡¡Se ha superado el límite de números (50)!!!");
                    cont = 50;
                }
                media = suma / cont;

                Console.WriteLine(cad);
                Console.WriteLine($"Número máximo: {max}");
                Console.WriteLine($"Número mínimo: {min}");
                Console.WriteLine($"La SUMA de todos los números introducidos es: {suma}");
                Console.WriteLine($"La MEDIA de todos los números introducidos es: {media}");

            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio19()
        {
            Console.WriteLine("EJERCICIO 19: Leer un número n por teclado y escribir el sumatorio de todos los números entre 1 y n.");

            try
            {
                //Definiendo variables
                int n = 0;
                int suma = 0;
                string cad = "Sumando los siguientes números: ";
                Console.WriteLine("Introduzca un número: ");
                n = Convert.ToInt32(Console.ReadLine());

                //Lógica del ejercicio
                while (n > 1)
                {
                    cad = cad + Convert.ToString(n) + "+";
                    suma = suma + n;
                    n--;
                }
                cad = cad + Convert.ToString(n);
                suma = suma + n;
                Console.WriteLine(cad);
                Console.WriteLine($"La SUMA es: {suma}");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio20()
        {
            Console.WriteLine("EJERCICIO 20: En el tipo de secuencia a(n)=3 * a(n-1) + 2 * a(n-2), descifrar el valor de " +
                "n cuando la secuencia es igual o mayor que 1000.");

            try
            {
                //Variabless
                int a = 0;
                int b = 1;
                int c = 3;
                int n = 3;
                string cad = "0, 1, ";
                c = (b * 3) + (a * 2);
                cad = cad + Convert.ToString(c) + ", ";

                Console.WriteLine("Pulse intro para continuar...");
                Console.ReadLine();

                //Lógica del ejercicio
                while (c <= 1000)
                {
                    n++;
                    a = b;
                    b = c;
                    c = (b * 3) + (a * 2);
                    cad = cad + Convert.ToString(c) + ", ";
                }
                Console.WriteLine("Secuencia: " + cad);
                Console.WriteLine("Posición para conseguir el primer resultado mayor o igual a 1000 (n): " + n);
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio21()
        {
            Console.WriteLine("EJERCICIO 21: Leer un número y decir si es capicúa. En una primera versión supondremos " +
                "que como máximo es un número de 6 cifras(entre 0 y 999.999)");

            try
            {
                //Definir variables
                bool capicua = true;
                string cadena;
                int i;
                Console.WriteLine("Introduzca un número: ");
                cadena = Console.ReadLine();
                if (cadena.Length > 6)
                {
                    Console.WriteLine("El número no debe ser más grande que 6 cifras");
                }
                else
                {
                    //Lógica que deduce si es capicúa (palíndromo), o no lo es
                    for (i = 0; i < cadena.Length / 2; i++)
                    {
                        if (cadena[i] != cadena[cadena.Length - 1 - i])
                        {
                            capicua = false;
                        }
                        
                    }
                    if (capicua == true)
                    {
                        Console.WriteLine($"{cadena} SÍ es capicúa.");
                    }
                    else
                    {
                        Console.WriteLine($"{cadena} NO es capicúa.");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio22()
        {
            Console.WriteLine("EJERCICIO 21: Leer un número y decir si es capicúa. De cualquier cantidad de cifras");

            try
            {
                //Definir variables
                bool capicua = true;
                string cadena;
                int i;
                Console.WriteLine("Introduzca un número: ");
                cadena = Console.ReadLine();
                
                //Lógica que deduce si es capicúa (palíndromo), o no lo es
                for (i = 0; i < cadena.Length / 2; i++)
                {
                    if (cadena[i] != cadena[cadena.Length - 1 - i])
                    {
                        capicua = false;
                    }

                }
                if (capicua == true)
                {
                    Console.WriteLine($"{cadena} SÍ es capicúa.");
                }
                else
                {
                    Console.WriteLine($"{cadena} NO es capicúa.");
                }
                
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio23()
        {
            Console.WriteLine("EJERCICIO 23: MASTERMIND");

            try
            {
                //Definir las variables
                bool jugar = false;
                int cont = 0;
                int muerto = 0;
                int herido = 0;

                //Variables para separar los números introducidos para así poder compararlas
                char a1;
                char b1;
                char c1;
                char d1;
                char a2;
                char b2;
                char c2;
                char d2;

                string sec1 = "";
                string sec2 = "";
                string sec3 = "";
                string sec4 = "";
                string try1 = "";
                string try2 = "";
                string try3 = "";
                string try4 = "";

                Console.WriteLine("Bienvenido al MASTER MIND");
                Console.WriteLine("Dime la combinación secreta (4 números)");
                //Pedimos y definimos la variable que se usará como código a adivinar
                while (jugar != true)
                {
                    string secret = Console.ReadLine();
                    //Comprobamos que sea de 4 dígitos, si es así, asignamos jugar = true
                    if (secret.Length == 4)
                    {
                        jugar = true;
                        a1 = secret[1];
                        b1 = secret[2];
                        c1 = secret[3];
                        d1 = secret[4];
                        sec1 = Convert.ToString(a1);
                        sec2 = Convert.ToString(b1);
                        sec3 = Convert.ToString(c1);
                        sec4 = Convert.ToString(d1);
                    }
                    else
                    {
                        Console.WriteLine("El número introducido no contiene 4 dígitos, por favor, introduzca uno válido: ");
                    }
                }
                //Si conseguimos que jugar = true, pasamos al siguiente paso, donde empezamoas a pedir el número
                //que va a intentar adivinar el código secreto
                while (cont <= 8 || muerto < 4)
                {
                    muerto = 0;
                    herido = 0;
                    cont++;
                    bool intento = false;
                    while (intento != true)
                    {
                        //Definimos la variable jugada y comprobamos que tenga 4 dígitos, entonces asignamos intento = true
                        Console.WriteLine($"Jugada Nº{cont}");
                        Console.WriteLine("Dime tu jugada (4 números)");
                        string jugada = Console.ReadLine();
                        if (jugada.Length == 4)
                        {
                            intento = true;
                            a2 = jugada[1];
                            b2 = jugada[2];
                            c2 = jugada[3];
                            d2 = jugada[4];
                            try1 = Convert.ToString(a2);
                            try2 = Convert.ToString(b2);
                            try3 = Convert.ToString(c2);
                            try4 = Convert.ToString(d2);

                        }
                        else
                        {
                            Console.WriteLine("El número introducido no contiene 4 dígitos, por favor, introduzca uno válido: ");
                        }
                    }
                    if (intento == true)
                    {
                        if (try1 == sec1)
                        {
                            muerto++;
                        }
                        else if (try1 == sec2 || try1 == sec3 || try1 == sec4)
                        {
                            herido++;
                        }
                        if (try2 == sec2)
                        {
                            muerto++;
                        }
                        else if (try2 == sec1 || try2 == sec3 || try2 == sec4)
                        {
                            herido++;
                        }
                        if (try3 == sec3)
                        {
                            muerto++;
                        }
                        else if (try3 == sec1 || try3 == sec2 || try3 == sec4)
                        {
                            herido++;
                        }
                        if (try4 == sec4)
                        {
                            muerto++;
                        }
                        else if (try4 == sec1 || try4 == sec2 || try4 == sec3)
                        {
                            herido++;
                        }
                        Console.WriteLine($"MUERTOS: {muerto}");
                        Console.WriteLine($"HERIDOS: {herido}");
                    }
                }
                if (muerto == 4)
                {
                    Console.WriteLine("FELICIDADES, JUEGO COMPLETADO!!!");
                }
                else if (muerto < 4)
                {
                    Console.WriteLine("MALA SUERTE, INTÉNTALO DE NUEVO.");
                }
                Console.WriteLine("Fin del Juego, volviendo al menú principal...");
            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio24()
        {
            Console.WriteLine("EJERCICIO 24");

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
            Console.WriteLine("EJERCICIO 25");

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
            Console.WriteLine("EJERCICIO 26");

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
            Console.WriteLine("EJERCICIO 27");

            try
            {
                bool perfecto = false;
                int numero = Convert.ToInt32(Console.ReadLine());
                if (/*Lódica para que perfecto pueda ser true*/numero == 6)
                {
                    perfecto = true;
                }
                else if (numero == 5)
                {
                    perfecto = false;
                }
                else
                {
                    Console.WriteLine("Por favor, introduzca un número correcto.");
                }


            }
            catch
            {
                Console.WriteLine("Error");
            }
        }

        static void Ejercicio28()
        {
            Console.WriteLine("EJERCICIO 28");

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
            Console.WriteLine("EJERCICIO 29");

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
