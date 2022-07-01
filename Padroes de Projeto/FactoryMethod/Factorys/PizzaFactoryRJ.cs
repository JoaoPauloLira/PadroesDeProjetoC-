using Padroes_de_Projeto.FactoryMethod.ModelosPizza;

namespace Padroes_de_Projeto.FactoryMethod.Factorys
{
    public class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            return tipo switch
            {
                "M" => new PizzaMussarelaRJ(),
                "C" => new PizzaCalabresaRJ(),
                _ => null
            };
        }
    }
}
