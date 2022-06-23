using System;
using System.Collections.Generic;
using System.Globalization;

namespace Aula_15_Checkpoint
{
    internal class Convercao
    {

        public string opcao;
        Dictionary<double, double> Moedas = new Dictionary<double, double>();
       

        public void valores()
        {
            Moedas.Add(1, 4.50);   // 1 Dolar
            Moedas.Add(2, 6.20);   // 2 Euro
            Moedas.Add(3, 0.052);  // 3 Iene
            Moedas.Add(4, 1.0);    // 4 Libra
        }

        //public double conversao(double valorReal, double opcao)
        //{
            
        //    if (Moedas.ContainsKey(opcao))
        //    {
        //        double valor = valorReal / Moedas[opcao-1];
        //    }

        //}

        public void conversaoDolar(double valor)
        {
               if (Moedas.ContainsKey(1))
            {
                valor = double.Parse(Console.ReadLine());
                valor = Moedas[0] * valorReal;
                
            }        
            
        }


        public double conversaoEuro(double valorReal, double valor)
        {
            if (Moedas.ContainsKey(2))
            {
                valor = Moedas[1] * valorReal;
            }
            return valor;
        }


        public void conversaoIene(double valorReal)
        {
            if (Moedas.ContainsKey(3))
            {
                double valor = Moedas[2] * valorReal;
            }

        }


        public void conversaoLibra(double valorReal)
        {
            if (Moedas.ContainsKey(1))
            {
                double valor = Moedas[0] * valorReal;
            }

        }


        public void EscolherMoeda()
        {
         
            do
            {
                Console.WriteLine("1 - Dolar");
                Console.WriteLine("2 - Euro");
                Console.WriteLine("3 - Iene");
                Console.WriteLine("4 - Libra");
                Console.WriteLine("5 - Sair da Convercao");
                Console.WriteLine("");
                Console.Write("Para qual moeda deseja converter?" + Environment.NewLine + ">");
                opcao = double.Parse(Console.ReadLine());
                Console.Write($"Quantos reais deseja converter?" + Environment.NewLine + ">");
                double valorReal = double.Parse(Console.ReadLine());
                double opcao = double.Parse(Console.ReadLine());



                double valor;
                Convercao operacao = null;

                switch (opcao)
                {
                    case 1:
                       conversaoDolar(valor);
                       Console.WriteLine("Total: " + valor);
                        break;
                    case 2:
                    //    conversaoEuro(valorReal,  valor);    
                        break;
                    case 3:
                        conversaoIene(valorReal);
                        break;
                    case 4:
                        conversaoLibra(valorReal);
                        break;
                    case 5:
                        Console.WriteLine("Programa encerrado.");
                        break;
                    default:
                        Console.WriteLine("Opção invalida.");
                        break;
                }

                if (operacao != null)
                {
                    conversao(valorReal, opcao);
                    Console.WriteLine("alguma coisa");
                    
                }

            } while (opcao != 6);
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

