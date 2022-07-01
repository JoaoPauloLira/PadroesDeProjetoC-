using Padroes_de_Projeto.FactoryMethod.ModelosPizza;

namespace Padroes_de_Projeto.FactoryMethod.Factorys
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override Pizza CriarPizza(string tipo)
        {
            return tipo switch
            {
                "M" => new PizzaMussarelaSP(),
                "C" => new PizzaCalabresaSP(),
                _ => null
            };
        }
    }
}
