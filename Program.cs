using System;

namespace Sistema_de_Soma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, Somando;

            Console.Write("Informe o Primeiro Número: ");
            numero1 = int.Parse(Console.ReadLine());

            Console.Write("Informe o Segundo Número: ");
            numero2 = int.Parse(Console.ReadLine());

            Somando = numero1 + numero2;

            Console.Write("Resultado = " + Somando);
            Console.ReadKey();

        }
    }
}
