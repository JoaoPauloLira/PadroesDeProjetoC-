namespace Padroes_de_Projeto.StarBuzz_Decorate.Bebidas
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast Coffe";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }
}
