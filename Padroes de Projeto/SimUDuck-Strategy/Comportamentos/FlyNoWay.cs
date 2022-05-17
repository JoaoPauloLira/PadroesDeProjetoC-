using Padroes_de_Projeto.SimUDuck.Interfaces;
using System;

namespace Padroes_de_Projeto.SimUDuck.Comportamentos
{
    //Classe de implementação concreta da interface IFlyBehavior
    public class FlyNoWay : IFlyBehavior
    {
        //Não sabe Voar
        public void Fly()
        {
            Console.WriteLine("<< Não voa >>");
        }
    }
}
