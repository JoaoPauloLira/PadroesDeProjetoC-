using System;

namespace Padroes_de_Projeto.FactoryMethod.Factorys
{
    public static class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string local)
        {
            PizzaFactoryMethod pizzaria = local switch
            {
                "S" => new PizzaFactorySP(),
                "R" => new PizzaFactoryRJ(),
                _ => throw new ApplicationException($"A pizzaria {local} não fornece essa pizza")
            };
            return pizzaria;
        }
    }
}
