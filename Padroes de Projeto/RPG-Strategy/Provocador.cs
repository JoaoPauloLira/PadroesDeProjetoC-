namespace Padroes_de_Projeto.RPG_Strategy
{
    public class Provocador : Personagem
    {
        public override void Figth()
        {
            _comportamentoDeArma.UsarArma();
        }
    }
}
