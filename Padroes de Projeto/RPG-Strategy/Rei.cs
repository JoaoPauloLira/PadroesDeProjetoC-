namespace Padroes_de_Projeto.RPG_Strategy
{
    public class Rei : Personagem
    {
        public override void Figth()
        {
            _comportamentoDeArma.UsarArma();
        }
    }
}
