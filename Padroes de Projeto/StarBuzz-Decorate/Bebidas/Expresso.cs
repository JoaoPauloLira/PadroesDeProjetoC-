namespace Padroes_de_Projeto.StarBuzz_Decorate.Bebidas
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
