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
    }

}
