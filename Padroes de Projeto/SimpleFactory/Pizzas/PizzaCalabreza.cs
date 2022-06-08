using Padroes_de_Projeto.SimpleFactory.Enum;
using System;

namespace Padroes_de_Projeto.SimpleFactory
{
    internal class PizzaCalabreza : Pizza
    {
        public PizzaCalabreza() : base(TipoPizza.Calabresa)
        {
            Name = "Pizza de Calabreza";
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
