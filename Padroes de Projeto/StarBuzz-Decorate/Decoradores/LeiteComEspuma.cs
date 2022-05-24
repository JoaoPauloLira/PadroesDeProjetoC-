namespace Padroes_de_Projeto.StarBuzz_Decorate.Decoradores
{
    public class LeiteComEspuma : CondimentDecorator
    {
        private readonly Beverage _beverage;

        public LeiteComEspuma(Beverage beverage)
        {
            _beverage = beverage;
            description = GetDescription();
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Leite com espuma";
        }

        public override double Cost()
        {
            return _beverage.Cost() + 0.10;
        }
    }
}
