using System;

namespace ConsoleApp1.ExercicioQuatroListaDois
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício quatro // Lista dois");
            int Numero;

            do
            {
                

                
                Console.WriteLine("Informe um número");
                Numero = Convert.ToInt32(Console.ReadLine());

                if (Numero % 2 == 0) 
                    Console.WriteLine("O número é par");
                else
                    Console.WriteLine("O número é ímpar");



            } while(true);
        }
    }
}
