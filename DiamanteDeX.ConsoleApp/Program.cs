namespace DiamanteDeX.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diamante de X");
            Console.WriteLine("Digite um número ímpar: ");
            int numeroImpar = Convert.ToInt32(Console.ReadLine());

            if (numeroImpar % 2 == 0)
            {
                Console.WriteLine("ATENÇÃO - Informe um número válido!");
                Console.WriteLine("Digite um número ímpar: ");
                numeroImpar = Convert.ToInt32(Console.ReadLine());
            }

            int espacos = numeroImpar / 2;
            int quantX = 1;

            for (int i = 0; i < numeroImpar / 2; i++)
            {
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < quantX; k++) 
                { 
                    Console.Write("X");
                }
                Console.WriteLine();

                espacos--;
                quantX += 2;
            }

            for (int i = 0; i < numeroImpar / 2 + 1; i++)
            {
                for (int j = 0; j < espacos; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < quantX; k++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();

                espacos++;
                quantX -= 2;
            }
            Console.ReadLine();
        }
    }
}
