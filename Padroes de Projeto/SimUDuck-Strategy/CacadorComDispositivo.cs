using Padroes_de_Projeto.SimUDuck.Comportamentos;
using Padroes_de_Projeto.SimUDuck.Interfaces;

namespace Padroes_de_Projeto.SimUDuck
{
    public class CacadorComDispositivo
    {
        private readonly IQuackBehavior _quackBehavior;

        public CacadorComDispositivo()
        {
            _quackBehavior = new DispositivoQuack();
        }

        public void Quack()
        {
            _quackBehavior.quack();
        }
    }
}
