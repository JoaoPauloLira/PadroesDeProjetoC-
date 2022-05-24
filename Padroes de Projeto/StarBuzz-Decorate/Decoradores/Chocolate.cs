namespace Padroes_de_Projeto.StarBuzz_Decorate.Decoradores
{
    public class Chocolate : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Chocolate(Beverage beverage)
        {
            _beverage = beverage;
            description = GetDescription();
        }
        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Chocolate";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.20;
        }
    }
}
