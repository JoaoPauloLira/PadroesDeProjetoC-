using Padroes_de_Projeto.SimpleFactory.Enum;

namespace Padroes_de_Projeto.SimpleFactory
{
    internal abstract class Pizza
    {
        public Pizza(TipoPizza tipoPizza)
        {
            TipoPizza = tipoPizza;
        }

        public string Name { get; set; }
        public TipoPizza TipoPizza { get; set; }
        public abstract void Preparar();
        public abstract void Assar(int tempoEmMinutos);
        public abstract void Embalar();

    }
}
