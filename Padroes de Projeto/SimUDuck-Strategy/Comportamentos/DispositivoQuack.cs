using Padroes_de_Projeto.SimUDuck.Interfaces;
using System;

namespace Padroes_de_Projeto.SimUDuck.Comportamentos
{
    public class DispositivoQuack : IQuackBehavior
    {
        public void quack()
        {
            Console.WriteLine("Dispositivo para chamar patos");
        }
    }
}
