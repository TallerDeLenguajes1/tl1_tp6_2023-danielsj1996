internal class Program
{
    
    private static void Main(string[] args)
    {

        Console.WriteLine("Bienvenido/a");

        int numero = 0;
        bool funciona = false;
        string? numString = "";


        int OrdenInverso(int numero)
        {
            int resultado = 0;
            while (numero > 0)
            {
                resultado = resultado * 10 + numero % 10;
                numero /= 10;
            }
            return resultado;
        }

        while (!funciona)
        {

            Console.WriteLine("Ingrese el numero a invertir:");
            numString = Console.ReadLine();
            funciona = int.TryParse(numString, out numero);



            if (!funciona)
            {
                Console.WriteLine(numString + " No es un numero valido ");
            }
            else
            {
                {

                    int numeroInverso = OrdenInverso(numero);

                    Console.WriteLine("El número inverso de {0}, es {1}", numero, numeroInverso);

                }
            }
        }

        Console.WriteLine("Cadenas");
        Console.WriteLine("Ingrese una Cadena de Caracteres: ");
        string? Cadena1 = Console.ReadLine();

        int longitud = Cadena1.Length;
        Console.WriteLine("La longitud de la 1ra Cadena es: \n" + longitud);

        Console.WriteLine("Ingrese una 2da Cadena de Caracteres: ");
        string? Cadena2 = Console.ReadLine();

        string Cadena3 = Cadena1 + Cadena2;
        Console.WriteLine("Las 2 cadenas concatenadas dan como resultado: " + Cadena3);

        string subCadena = Cadena3.Substring(5, 5);
        Console.WriteLine("La subcadena es: \n" + subCadena);



        Console.Write("\n");
        Console.Write("\n");
        Console.Write("Recorrido de la Cadena: \n");
        foreach (char caracter in Cadena3)
        {
            Console.WriteLine(caracter);
        }



        Console.WriteLine("Ingrese la palabra a buscar: \n");
        string? palabra = Console.ReadLine();
        bool busqueda = Cadena3.Contains(palabra, System.StringComparison.CurrentCultureIgnoreCase);

        Console.WriteLine($"La cadena contiene la palabra buscada? {busqueda}");

        Console.Write("\n");
        Console.WriteLine("Cadena en Mayusculas: \n" + Cadena3.ToUpper());
        Console.Write("\n");

        Console.WriteLine("Cadena en Minusculas: \n" + Cadena3.ToLower());

        Console.Write("\n");
        Console.WriteLine("Ingresa una cadena separada por punto y coma (;): \n");
        string? cadena = Console.ReadLine();
        char delimitador = ';';
        string[] valores = cadena.Split(delimitador, StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Los resultados son:");

        foreach (string resultado in valores)
        {
            Console.WriteLine(resultado);
        }




    }

}
