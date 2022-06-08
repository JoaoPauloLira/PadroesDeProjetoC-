using Padroes_de_Projeto.SimpleFactory.Enum;
using System;

namespace Padroes_de_Projeto.SimpleFactory
{
    internal class PizzaMussarela : Pizza
    {
        public PizzaMussarela() : base(TipoPizza.Mussarela)
        {
            Name = "Pizza de Mussarela";
        }
        public override void Preparar()
        {
            Console.WriteLine($"Preparando a pizza de {Name}");
        }

        public override void Assar(int tempoEmMinutos)
        {
            Console.WriteLine($"Pizza de {Name} assando por {tempoEmMinutos} minutos");
        }

        public override void Embalar()
        {
            Console.WriteLine($"Embalando a Pizza de {Name}");
        }
    }
}
