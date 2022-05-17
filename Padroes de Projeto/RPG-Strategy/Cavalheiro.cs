namespace Padroes_de_Projeto.RPG_Strategy
{
    public class Cavalheiro : Personagem
    {
        public override void Figth()
        {
            _comportamentoDeArma.UsarArma();
        }
    }
}
