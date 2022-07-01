namespace Padroes_de_Projeto.FactoryMethod.ModelosPizza
{
    public class PizzaMussarelaRJ : Pizza
    {
        public PizzaMussarelaRJ()
        {
            Nome = "Pizza de Mussarela Carioca";
            Massa = "Massa fina crocante Carioca";
            Molho = "Molho de tomate italiano Carioca";
            Ingredientes.Add("Queijo parmessão ralado");
            Ingredientes.Add("Azeitonas pretas");
        }
    }
}
