namespace Padroes_de_Projeto.StarBuzz_Decorate.Decoradores
{
    public class Soja : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public Soja(Beverage beverage)
        {
            _beverage = beverage;
            description = GetDescription();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soja";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.15;
        }
    }
}
