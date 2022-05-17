using Padroes_de_Projeto.SimUDuck.Interfaces;
using System;

namespace Padroes_de_Projeto.SimUDuck.Comportamentos
{
    public class FlyRocketPowered : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Fly: Voar como um foguete");
        }
    }
}
