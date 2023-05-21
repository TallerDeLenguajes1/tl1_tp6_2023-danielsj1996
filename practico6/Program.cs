//Ejercicio 3. Ingrese al Branch CalculadoraV2 para implementar las mejoras en la
//calculadora.. Solicite al usuario un número y muestre por pantalla:
//● El valor absoluto de un número
//● El cuadrado
//● La raíz cuadrada
//● El seno
//● El Coseno
//● La parte entera de un tipo float.
//Luego de esto, solicite dos números al usuario y determine:
//● El Máximo entre los dos números
//● El Mínimo entre los dos números
//Combine el código del branch CalculadoraV2 en el branch de CalculadoraV1 y
//resuelva los conflictos surgidos. Para TODOS los casos, no olvide contemplar siempre
//el caso de que el usuario no ingrese un número válido.
//Suba al repositorio github ambas ramas.



internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la Calculadora V1");

        double numero1 = 0;
        bool funciona1 = false;
        string? numString1 = "";
        double numero2 = 0;
        bool funciona2 = false;
        string? numString2 = "";


        while (!funciona1 && !funciona2)
        {


            Console.WriteLine("(1)- Absoluto");
            Console.WriteLine("(2)- Cuadrado");
            Console.WriteLine("(3)- Raiz Cuadrada");
            Console.WriteLine("(4)- Seno");
            Console.WriteLine("(5)- Coseno");
            Console.WriteLine("(6)- Parte Entera");
            Console.WriteLine("(7)- Mayor y Menor");
            Console.WriteLine("(8)- salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:

                    Console.WriteLine("Has elegido la opción de Calcular el valor absoluto del Nro a ingresar");
                    Console.WriteLine("Ingrese el número en la calculadora:");
                    numString1 = Console.ReadLine();
                    funciona1 = double.TryParse(numString1, out numero1);
                    if (!funciona1)
                    {
                        Console.WriteLine(numString1 + " No son numeros validos");
                    }
                    else
                    {
                        double absoluto = Math.Abs(numero1);
                        Console.WriteLine("El resultado del Valor Absoluto de "+numero1+" : " + absoluto);
                    }
                    break;

                case 2:
                    Console.WriteLine("Has elegido la opción de Calcular el cuadrado del Nro a ingresar");
                    Console.WriteLine("Ingrese el número en la calculadora:");
                    numString1 = Console.ReadLine();
                    funciona1 = double.TryParse(numString1, out numero1);

                    if (!funciona1)
                    {
                        Console.WriteLine(numString1 + " No son numeros validos");
                    }
                    else
                    {
                        double Cuadrado = Math.Pow(numero1, 2);
                        Console.WriteLine("El resultado del valor del Nro "+numero1+" elevado al Cuadrado es : " + Cuadrado);
                    }

                    break;

                case 3:
                    Console.WriteLine("Has elegido la opción de Calcular el Seno del Nro a ingresar");
                    Console.WriteLine("Ingrese el número en la calculadora:");
                    numString1 = Console.ReadLine();
                    funciona1 = double.TryParse(numString1, out numero1);
                    if (!funciona1)
                    {
                        Console.WriteLine(numString1 + " No son numeros validos");
                    }
                    else
                    {
                        double Raiz = Math.Sqrt(numero1);
                        Console.WriteLine("El resultado de la Raiz Cuadrada de "+numero1+" es : " + Raiz);
                    }
                    break;
                case 4:
                    Console.WriteLine("Has elegido la opción de Calcular el Coseno del Nro a ingresar");
                    Console.WriteLine("Ingrese el número en la calculadora:");
                    numString1 = Console.ReadLine();
                    funciona1 = double.TryParse(numString1, out numero1);
                    if (!funciona1)
                    {
                        Console.WriteLine(numString1 + " No son numeros validos");
                    }
                    else
                    {
                        double Seno = Math.Sin(numero1);
                        Console.WriteLine("El resultado del Seno de "+numero1+" es : " + Seno);
                    }
                    break;
                case 5:
                    Console.WriteLine("Has elegido la opción de Calcular el Coseno del nro a ingresar");
                    Console.WriteLine("Ingrese el número en la calculadora:");
                    numString1 = Console.ReadLine();
                    funciona1 = double.TryParse(numString1, out numero1);
                    if (!funciona1)
                    {
                        Console.WriteLine(numString1 + " No son numeros validos");
                    }
                    else
                    {
                        double Coseno = Math.Cos(numero1);
                        Console.WriteLine("El resultado del Seno de "+numero1+" es : " + Coseno);
                    }
                    break;
                case 6:
                    Console.WriteLine("Has elegido la opción de Calcular la Parte Entera del Nro a ingresar");
                    Console.WriteLine("Ingrese el número en la calculadora:");
                    double numero3 = 0;
                    numString1 = Console.ReadLine();
                    funciona1 = double.TryParse(numString1, out numero3);
                    if (!funciona1)
                    {
                        Console.WriteLine(numString1 + " No son numeros validos");
                    }
                    else
                    {
                        double ParteEntera = Math.Truncate(numero3);
                        Console.WriteLine("La parte entera de "+numero3+" es : " + ParteEntera);
                    }
                    break;
                case 7:
                    Console.WriteLine("Has elegido la opción de Calcular el Maximo y Minimo valor entre 2 Nros");
                    Console.WriteLine("Ingrese el número en la calculadora:");
                    numString1 = Console.ReadLine();
                    funciona1 = double.TryParse(numString1, out numero1);
                    numString2 = Console.ReadLine();
                    funciona2 = double.TryParse(numString2, out numero2);
                    if (!funciona1 || !funciona2)
                    {
                        Console.WriteLine(numString1 + " o " + numString2 + " No son numeros validos");
                    }
                    else
                    {
                        double Maximo = Math.Max(numero1, numero2);
                        double Minimo = Math.Min(numero1, numero2);
                        Console.WriteLine("El Valor maximo entre "+numero1+" y "+numero2+" es : " + Maximo);
                        Console.WriteLine("El Valor Minimo entre "+numero1+" y "+numero2+" es : " + Minimo);
                    }
                    break;


                default:

                    break;



            }
        }
    }
}
