namespace Padroes_de_Projeto.StarBuzz_Decorate
{
    public abstract class Beverage
    {
        protected string description = "Bebida desconhecida";

        public string GetDescription() => description;

        public abstract double Cost();
    }
}
