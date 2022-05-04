using Padroes_de_Projeto.Strategy;
using System;

namespace Padroes_de_Projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            var orcamento = new Orcamento(500.0);

            var calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);

        }

    }
}
