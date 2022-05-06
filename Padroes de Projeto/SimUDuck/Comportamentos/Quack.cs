using Padroes_de_Projeto.SimUDuck.Interfaces;
using System;

namespace Padroes_de_Projeto.SimUDuck.Comportamentos
{
    //Classe de implementação concreta da interface IQuackBehavior
    public class Quack : IQuackBehavior
    {
        //Grosnar
        public void quack()
        {
            Console.WriteLine("quack: Grosnar");
        }
    }
}
