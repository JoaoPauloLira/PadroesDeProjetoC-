using Padroes_de_Projeto.SimpleFactory.Enum;

namespace Padroes_de_Projeto.SimpleFactory
{
    internal sealed class PizzaSimpleFactory //sealed: para evitar que seja herdada
    {
        public static Pizza CriarPizza(TipoPizza tipoPizza)
        {
            Pizza pizza = tipoPizza switch
            {
                TipoPizza.Calabresa => new PizzaCalabreza(),
                TipoPizza.Mussarela => new PizzaMussarela(),
                _ => null
            };
            return pizza;
        }
    }
}
