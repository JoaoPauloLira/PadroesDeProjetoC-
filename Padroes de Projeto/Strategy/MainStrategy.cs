using System;

namespace Padroes_de_Projeto.Strategy
{
    public class MainStrategy
    {
        public MainStrategy()
        {
            Console.WriteLine("Strategy");

            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            var orcamento = new Orcamento(500.0);

            var calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            Console.WriteLine("FIM");
        }

    }
}
