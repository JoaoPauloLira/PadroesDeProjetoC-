namespace Padroes_de_Projeto.StarBuzz_Decorate.Decoradores
{
    public class Creme : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Creme(Beverage beverage)
        {
            _beverage = beverage;
            description = GetDescription();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Creme";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.10;
        }
    }
}
