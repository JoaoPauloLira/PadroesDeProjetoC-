using System;

namespace Padroes_de_Projeto.ChainOfResponsibility
{
    public class MainChainOfResponsibility
    {
        public MainChainOfResponsibility()
        {
            Console.WriteLine("Chain Of Responsibility");

            var calculador = new CalculadorDeDescontos();

            var orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250.0));
            orcamento.AdicionaItem(new Item("FOGAO", 250.0));
            orcamento.AdicionaItem(new Item("MICROONDAS", 250.0));
            orcamento.AdicionaItem(new Item("PS4", 250.0));

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.WriteLine("FIM");
        }

    }
}
