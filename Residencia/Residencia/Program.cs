using System;
using System.Collections.Generic;
using System.Text;

namespace Residencia
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite A");
            int A = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite B");
            int B = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite C");
            int C = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite D");
            int D = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Digite E");
            int E = Convert.ToInt32(Console.ReadLine());
            int SOMA = A + B + C + D + E;
            
            float MEDIA = 0;
            MEDIA = SOMA / 5;
            int MAIOR = 0;
            int MENOR = 0;

            //Implementar media maior e menor
            MAIOR = A;
            MENOR = A;
            
            //Comparacao MAIOR
            if (MAIOR < B)
                MAIOR = B;

            if (MAIOR < C)
                MAIOR = C;

            if (MAIOR < D)
                MAIOR = D;

            if (MAIOR < E)
                MAIOR = E;

            //Comparação MENOR
            if (MENOR > B)
                MENOR = B;

            if (MENOR > C)
                MENOR = C;

            if (MENOR > D)
                MENOR = D;

            if (MENOR > E)
                MENOR = E;

            //Console.Title = "TESTE123";
            Console.WriteLine("A = " + A + "\nB = " + B + "\nC = " + C + "\nD = " + D + "\nE = " + E);
            Console.WriteLine("\nMAIOR = " + MAIOR + "\nMENOR = " + MENOR + "\nSOMA = " + SOMA + "\nMEDIA = " + MEDIA);
            Console.ReadLine();
        }
    }
}