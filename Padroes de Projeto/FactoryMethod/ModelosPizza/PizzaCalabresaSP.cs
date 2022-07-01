namespace Padroes_de_Projeto.FactoryMethod.ModelosPizza
{
    public class PizzaCalabresaSP : Pizza
    {
        public PizzaCalabresaSP()
        {
            Nome = "Pizza de Calabresa Paulista com muita calabreza";
            Massa = "Massa fina crocante";
            Molho = "Molho de tomate italiano";
            Ingredientes.Add("Fatias de calabresa defumada especial");
            Ingredientes.Add("Queijo parmessão italiano tradicional");
        }
    }
}
