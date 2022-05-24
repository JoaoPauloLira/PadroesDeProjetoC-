namespace Padroes_de_Projeto.StarBuzz_Decorate.Bebidas
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffee";
        }
        public override double Cost()
        {
            return 0.89;
        }
    }
}
