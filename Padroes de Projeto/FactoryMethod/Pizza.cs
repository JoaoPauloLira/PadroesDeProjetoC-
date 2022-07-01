using System.Collections;
using System.Text;

namespace Padroes_de_Projeto.FactoryMethod
{
    public abstract class Pizza
    {
        protected string Nome { get; set; }
        protected string Massa { get; set; }
        protected string Molho { get; set; }
        protected ArrayList Ingredientes = new ArrayList();

        public string Preparar()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Preparando {Nome}");
            sb.AppendLine(Massa);
            sb.AppendLine(Molho);
            sb.AppendLine("Ingredientes :");
            foreach (var ingrediente in Ingredientes)
            {
                sb.AppendLine($"\t {ingrediente}");
            }

            sb.AppendLine(Cozinhar());
            sb.AppendLine(Fatiar());
            sb.AppendLine(Embalar());
            return sb.ToString();
        }

        public virtual string Embalar() =>
            "Embalar a pizza com embalagem oficial \n";

        public virtual string Fatiar() =>
            "Fatiar a pizza em 8 pedaços \n";

        public virtual string Cozinhar() =>
            "Cozinhar por 25 minutos a 350 Graus \n";
    }
}
