namespace Padroes_de_Projeto.FactoryMethod.ModelosPizza
{
    public class PizzaCalabresaRJ : Pizza
    {
        public PizzaCalabresaRJ()
        {
            Nome = "Pizza de Calabresa Carioca com muita calabreza";
            Massa = "Massa tradicional Carioca ";
            Molho = "Molho de tomate italiano Carioca";
            Ingredientes.Add("Fatias de calabresa especial");
            Ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
