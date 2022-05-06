using Padroes_de_Projeto.SimUDuck.Interfaces;
using System;

namespace Padroes_de_Projeto.SimUDuck.Comportamentos
{
    //Classe de implementação concreta da interface IFlyBehavior
    public class FlyWithWings : IFlyBehavior
    {
        //Voar
        public void Fly()
        {
            Console.WriteLine("fly: Voar");
        }
    }
}
