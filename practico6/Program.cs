internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido a la Calculadora V1");

        int numero1 = 0;
        int numero2 = 0;
        bool funciona1 = false;
        bool funciona2 = false;
        string? numString1 = "";
        string? numString2 = "";


        while (!funciona1 && !funciona2)
        {

            Console.WriteLine("Ingrese los números en la calculadora:");
            numString1 = Console.ReadLine();
            numString2 = Console.ReadLine();
            funciona1 = int.TryParse(numString1, out numero1);
            funciona2 = int.TryParse(numString2, out numero2);


            if (!funciona1 || !funciona2)
            {
                Console.WriteLine(numString1 + " o " + numString2 + " No son numeros validos");
            }
            else
            {
                {

                    Console.WriteLine("(1)-Suma");
                    Console.WriteLine("(2)- Resta");
                    Console.WriteLine("(3)- Multiplicacion");
                    Console.WriteLine("(4)- Dividision");
                    Console.WriteLine("(5)- salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                        {
                            case 1:
                                Console.WriteLine("Has elegido la opción de sumar los 2 numeros ingresados");
                                int suma = numero1 + numero2;
                                Console.WriteLine("El resultado de la suma es: " + suma);
                                break;

                            case 2:
                                Console.WriteLine("Has elegido la opción de restar los 2 numeros ingresados");
                                int resta = numero1 - numero2;
                                Console.WriteLine("El resultado de la resta es: " + resta);
                                break;

                            case 3:
                                Console.WriteLine("Has elegido la opción de multiplicar los 2 numeros");
                                int multiplicar = (numero1 * numero2);
                                Console.WriteLine("El resultado de la suma es: " + multiplicar);
                                break;
                            case 4:
                                Console.WriteLine("Has elegido la opción de dividir los 2 numeros");
                                if (numero2 > 0)
                                {
                                    int division = numero1 / numero2;
                                    Console.WriteLine("El resultado de la suma es: " + division);
                                }
                                else
                                {
                                    Console.WriteLine("No se pudo realizar la division");
                                }

                                break;


                            default:

                                break;

                        

                    }
                }
            }
        }
    }
}