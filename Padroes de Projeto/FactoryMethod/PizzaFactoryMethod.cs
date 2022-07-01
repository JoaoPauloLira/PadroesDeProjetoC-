namespace Padroes_de_Projeto.FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        public Pizza MontaPizza(string tipo)
        {
            var pizza = CriarPizza(tipo);
            return pizza;
        }

        protected abstract Pizza CriarPizza(string tipo);
    }
}
