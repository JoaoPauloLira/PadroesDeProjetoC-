using System;

namespace Padroes_de_Projeto.Strategy
{
    public class CalculadorDeImpostos
    {
        public void RealizaCalculo(Orcamento orcamento, Imposto imposto)
        {
            Console.WriteLine(imposto.Calcula(orcamento));
        }
    }
}
