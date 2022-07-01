namespace Padroes_de_Projeto.FactoryMethod.ModelosPizza
{
    public class PizzaMussarelaSP : Pizza
    {
        public PizzaMussarelaSP()
        {
            Nome = "Pizza de Mussarela Paulista";
            Massa = "Massa fina crocante paulista";
            Molho = "Molho de tomate italiano paulista";
            Ingredientes.Add("Queijo parmessão");
            Ingredientes.Add("Azeitonas verdes");
        }
    }
}
