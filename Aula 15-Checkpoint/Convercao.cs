using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_15_Checkpoint
{
    internal class Convercao
    {
        //public double Dolar;
        //public double Euro;
        //public double Iene;
        //public double Libra;

        Dictionary<double, double> Moedas = new Dictionary<double, double>();

        public void valores()
        {
       
            

            Moedas.Add(1, 4.50);   // 1 dolar
            Moedas.Add(2, 6.20);   // 2 Euro
            Moedas.Add(3, 0.052);  // 3 Iene
            Moedas.Add(4, 1.0);    // 4 Libra
        }

        public void  conversaoDolar(double valorReal)
        {
               if (Moedas.ContainsKey(1))
            {
                double valor = Moedas[0] * valorReal;
            }        
            
        }


        public void EscolherMoeda()
        {
            string opcao = "";
            do
            {

                Console.WriteLine("Em qual moeda deseja converter?" + Environment.NewLine + ">");
                double valorReal = double.Parse(Console.ReadLine());
                Console.WriteLine($"Quantos reais deseja converter para{opcao}" + Environment.NewLine + ">");
                Console.WriteLine("1 - Dolar");
                Console.WriteLine("2 - Euro");
                Console.WriteLine("3 - Iene");
                Console.WriteLine("4 - Libra");
                Console.WriteLine("5 - Sair da Convercao");

                opcao = Console.ReadLine();

                Convercao operacao = null;

                switch (opcao)
                {
                    case "1":
                        operacao = conversaoDolar();
                        break;
                    case "2":
                        operacao = new Subtracao();
                        break;
                    case "3":
                        operacao = new Multiplicacao();
                        break;
                    case "4":
                        operacao = new Divisao();
                        break;
                    case "5":
                        operacao = new Zerar();
                        break;
                    default:
                        Console.WriteLine("Calculadora encerrada");
                        break;
                }

                if (operacao != null)
                {
                    resultado = operacao.Executar(resultado);

                       );
                }

            } while (opcao != "6");

            //Console.WriteLine("Em qual moeda deseja converter?" + Environment.NewLine + ">");
            //int opcao = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Quantos reais deseja converter para{opcao}" + Environment.NewLine + ">");


        }


    }



}
//   Enum Moedas
//{
//  Dolar = 4.50,
//  Euro = 6.20,
//  Iene = 0.052,
//  Libra = 6.95,
//}

//public double Dolar = 4.50;
//public double Euro = 6.20;
//public double Iene = 0.052;
//public double Libra = 6.95;

