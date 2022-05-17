using Padroes_de_Projeto.RPG_Strategy.ComportamentosArmas;
using Padroes_de_Projeto.RPG_Strategy.Interfaces;

namespace Padroes_de_Projeto.RPG_Strategy
{
    public abstract class Personagem
    {
        public Personagem()
        {
            _comportamentoDeArma = new ComportamentoSemArma();
        }
        public ComportamentoDeArma _comportamentoDeArma;
        public abstract void Figth();

        public void SetComportamentoDeArma(ComportamentoDeArma comportamentoDeArma)
        {
            _comportamentoDeArma = comportamentoDeArma;
        }

    }
}
