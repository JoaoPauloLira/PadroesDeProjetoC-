using Padroes_de_Projeto.SimUDuck.Interfaces;
using System;

namespace Padroes_de_Projeto.SimUDuck.Comportamentos
{
    //Classe de implementação concreta da interface IQuackBehavior
    public class Squeak : IQuackBehavior
    {
        //Grosnar que parece um apito do pato de borracha
        public void quack()
        {
            Console.WriteLine("squeak: Grosnar(Apito)");
        }
    }
}
