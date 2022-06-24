using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_15_Checkpoint
{
    internal class Convercao
    {
        Dictionary<double, double> Moedas = new Dictionary<double, double>();
  
        public void Valores()
        {

            Moedas.Add(1, 4.50);   // 1 Dolar
            Moedas.Add(2, 6.20);   // 2 Euro
            Moedas.Add(3, 0.052);  // 3 Iene
            Moedas.Add(4, 6.95);   // 4 Libra
         
        }

        public void conversao(string opcao)
        {
            Console.Write($"Quantos reais deseja converter?" + Environment.NewLine + ">");
            double valorReal = double.Parse(Console.ReadLine());
            
            if (Moedas.ContainsKey(double.Parse(opcao)))
            {
                double resultado = valorReal * Moedas[double.Parse(opcao)];
                Console.WriteLine($"Valor da conversao é:{resultado}");

            }
            
        }


        public void EscolherMoeda()
        {
            string opcao = "";
            do
            {
                Console.WriteLine("");
                Console.WriteLine("1 - Dolar");
                Console.WriteLine("2 - Euro");
                Console.WriteLine("3 - Iene");
                Console.WriteLine("4 - Libra");
                Console.WriteLine("5 - Sair da Convercao");
                Console.WriteLine("");
                Console.Write("Para qual moeda deseja converter?" + Environment.NewLine + ">");
                opcao = Console.ReadLine();

          
                Convercao operacao = null;
                

                switch (opcao)
                {
                    case "1":
                        conversao(opcao);
                        break;
                    case "2":
                        conversao( opcao);
                        break;
                    case "3":
                        conversao( opcao);
                        break;
                    case "4":
                        conversao( opcao);
                        break;
                    default:
                        Console.WriteLine("Programa encerrado.");
                        break;
                }

                if (operacao != null)
                {
                   
                    Console.WriteLine("alguma coisa");

                }

            } while (opcao != "5");

        }
    }

}

