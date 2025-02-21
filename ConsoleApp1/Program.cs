using System;

class Program
{
    static void Main()
    {
        int opcion;
        do
        {
            // Mostramos el menú
            Console.WriteLine("----- Menú de Ejercicios -----");
            Console.WriteLine("1. Calculadora básica");
            Console.WriteLine("2. Validación de contraseña");
            Console.WriteLine("3. Números primos");
            Console.WriteLine("4. Suma de números pares");
            Console.WriteLine("5. Conversión de temperatura");
            Console.WriteLine("6. Contador de vocales");
            Console.WriteLine("7. Cálculo de factorial");
            Console.WriteLine("8. Juego de adivinanza");
            Console.WriteLine("9. Paso por referencia (intercambio de números)");
            Console.WriteLine("10. Tabla de multiplicar");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            // Validamos la opción ingresada
            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        CalculadoraBasica();
                        break;
                    case 2:
                        ValidacionContrasena();
                        break;
                    case 3:
                        NumerosPrimos();
                        break;
                    case 4:
                        SumaNumerosPares();
                        break;
                    case 5:
                        ConversionTemperatura();
                        break;
                    case 6:
                        ContadorVocales();
                        break;
                    case 7:
                        CalculoFactorial();
                        break;
                    case 8:
                        JuegoAdivinanza();
                        break;
                    case 9:
                        PasoPorReferencia();
                        break;
                    case 10:
                        TablaMultiplicar();
                        break;
                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intenta de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear(); // Limpia la consola antes de mostrar el menú nuevamente
        } while (opcion != 0);
    }

    // Ejercicio 1: Calculadora básica
    static void CalculadoraBasica()
    {
        Console.WriteLine("\n--- Calculadora Básica ---");
        Console.Write("Ingresa el primer número: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        double num2 = double.Parse(Console.ReadLine());

        Console.Write("Elige la operación (+, -, *, /): ");
        char operacion = Console.ReadLine()[0];

        double resultado = 0;
        switch (operacion)
        {
            case '+':
                resultado = num1 + num2;
                break;
            case '-':
                resultado = num1 - num2;
                break;
            case '*':
                resultado = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    resultado = num1 / num2;
                else
                    Console.WriteLine("Error: División por cero.");
                break;
            default:
                Console.WriteLine("Operación no válida.");
                break;
        }
        Console.WriteLine($"Resultado: {resultado}");
    }

    // Ejercicio 2: Validación de contraseña
    static void ValidacionContrasena()
    {
        Console.WriteLine("\n--- Validación de Contraseña ---");
        string contraseñaCorrecta = "segura123";
        Console.Write("Ingresa la contraseña: ");
        string contraseñaIngresada = Console.ReadLine();

        if (contraseñaIngresada == contraseñaCorrecta)
            Console.WriteLine("¡Contraseña correcta!");
        else
            Console.WriteLine("Contraseña incorrecta.");
    }

    // Ejercicio 3: Números primos
    static void NumerosPrimos()
    {
        Console.WriteLine("\n--- Números Primos ---");
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        bool esPrimo = true;
        if (numero <= 1)
            esPrimo = false;
        else
        {
            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }
            }
        }

        if (esPrimo)
            Console.WriteLine($"{numero} es un número primo.");
        else
            Console.WriteLine($"{numero} no es un número primo.");
    }

    // Ejercicio 4: Suma de números pares
    static void SumaNumerosPares()
    {
        Console.WriteLine("\n--- Suma de Números Pares ---");
        int sumaPares = 0;
        while (true)
        {
            Console.Write("Ingresa un número entero (0 para terminar): ");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                if (numero == 0) break;
                if (numero % 2 == 0) sumaPares += numero;
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }
        }
        Console.WriteLine($"La suma de los números pares ingresados es: {sumaPares}");
    }

    // Ejercicio 5: Conversión de temperatura
    static void ConversionTemperatura()
    {
        Console.WriteLine("\n--- Conversión de Temperatura ---");
        Console.WriteLine("1. Convertir de Celsius a Fahrenheit");
        Console.WriteLine("2. Convertir de Fahrenheit a Celsius");
        Console.Write("Elige una opción (1 o 2): ");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            double temperatura;
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingresa la temperatura en Celsius: ");
                    if (double.TryParse(Console.ReadLine(), out temperatura))
                    {
                        double fahrenheit = CelsiusAFahrenheit(temperatura);
                        Console.WriteLine($"{temperatura}°C equivale a {fahrenheit}°F");
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Debes ingresar un número.");
                    }
                    break;

                case 2:
                    Console.Write("Ingresa la temperatura en Fahrenheit: ");
                    if (double.TryParse(Console.ReadLine(), out temperatura))
                    {
                        double celsius = FahrenheitACelsius(temperatura);
                        Console.WriteLine($"{temperatura}°F equivale a {celsius}°C");
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Debes ingresar un número.");
                    }
                    break;

                default:
                    Console.WriteLine("Opción no válida. Debes elegir 1 o 2.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número.");
        }
    }

    static double CelsiusAFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitACelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    // Ejercicio 6: Contador de vocales
    static void ContadorVocales()
    {
        Console.WriteLine("\n--- Contador de Vocales ---");
        Console.Write("Ingresa una frase: ");
        string frase = Console.ReadLine();
        int cantidadVocales = ContarVocales(frase);
        Console.WriteLine($"La frase contiene {cantidadVocales} vocal(es).");
    }

    static int ContarVocales(string cadena)
    {
        int contador = 0;
        cadena = cadena.ToLower();
        foreach (char c in cadena)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') contador++;
        }
        return contador;
    }

    // Ejercicio 7: Cálculo de factorial
    static void CalculoFactorial()
    {
        Console.WriteLine("\n--- Cálculo de Factorial ---");
        Console.Write("Ingresa un número: ");
        int numero = int.Parse(Console.ReadLine());

        long factorial = 1;
        for (int i = 2; i <= numero; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {numero} es: {factorial}");
    }

    // Ejercicio 8: Juego de adivinanza
    static void JuegoAdivinanza()
    {
        Console.WriteLine("\n--- Juego de Adivinanza ---");
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int intento;
        int intentosRealizados = 0;
        bool adivinado = false;

        Console.WriteLine("He generado un número entre 1 y 100. ¡Adivina cuál es!");

        do
        {
            Console.Write("Ingresa tu intento: ");
            if (int.TryParse(Console.ReadLine(), out intento))
            {
                intentosRealizados++;
                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo. ¡Intenta de nuevo!");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto. ¡Intenta de nuevo!");
                }
                else
                {
                    adivinado = true;
                    Console.WriteLine($"¡Felicidades! Adivinaste el número en {intentosRealizados} intento(s).");
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Debes ingresar un número.");
            }
        } while (!adivinado);
    }

    // Ejercicio 9: Paso por referencia (intercambio de números)
    static void PasoPorReferencia()
    {
        Console.WriteLine("\n--- Paso por Referencia (Intercambio de Números) ---");
        Console.Write("Ingresa el primer número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Ingresa el segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nValores originales: número1 = {numero1}, número2 = {numero2}");
        Intercambiar(ref numero1, ref numero2);
        Console.WriteLine($"Valores intercambiados: número1 = {numero1}, número2 = {numero2}");
    }

    static void Intercambiar(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // Ejercicio 10: Tabla de multiplicar
    static void TablaMultiplicar()
    {
        Console.WriteLine("\n--- Tabla de Multiplicar ---");
        Console.Write("Ingresa un número para generar su tabla de multiplicar: ");

        if (int.TryParse(Console.ReadLine(), out int numero))
        {
            int[] tabla = GenerarTablaMultiplicar(numero);
            MostrarTablaMultiplicar(numero, tabla);
        }
        else
        {
            Console.WriteLine("Entrada no válida. Debes ingresar un número entero.");
        }
    }

    static int[] GenerarTablaMultiplicar(int numero)
    {
        int[] tabla = new int[10];
        for (int i = 0; i < 10; i++)
        {
            tabla[i] = numero * (i + 1);
        }
        return tabla;
    }

    static void MostrarTablaMultiplicar(int numero, int[] tabla)
    {
        Console.WriteLine($"\nTabla de multiplicar del {numero}:\n");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{numero} x {i + 1} = {tabla[i]}");
        }
    }
}