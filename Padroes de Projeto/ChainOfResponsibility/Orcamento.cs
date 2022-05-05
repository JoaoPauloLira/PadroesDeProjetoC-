using System.Collections.Generic;

namespace Padroes_de_Projeto.ChainOfResponsibility
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IList<Item> Itens { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
        }
    }
}
