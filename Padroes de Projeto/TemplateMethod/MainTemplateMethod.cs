using System;

namespace Padroes_de_Projeto.TemplateMethod
{
    public class MainTemplateMethod
    {
        public MainTemplateMethod()
        {
            Console.WriteLine("Template Method");

            var orcamento = new Orcamento(500.0);
            orcamento.AdicionaItem(new Item("CANETA", 250.0));
            orcamento.AdicionaItem(new Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new Item("GELADEIRA", 250.0));
            orcamento.AdicionaItem(new Item("FOGAO", 250.0));
            orcamento.AdicionaItem(new Item("MICROONDAS", 250.0));
            orcamento.AdicionaItem(new Item("PS4", 250.0));

            var ikcv = new IKCV();
            var icpp = new ICPP();

            Console.WriteLine(ikcv.Calcula(orcamento));
            Console.WriteLine(icpp.Calcula(orcamento));

            Console.WriteLine("FIM");
        }

    }
}
