using Padroes_de_Projeto.SimUDuck.Comportamentos;
using System;

namespace Padroes_de_Projeto.SimUDuck
{
    //Pato-real
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            _quackBehavior = new Quack();
            _flyBehavior = new FlyWithWings();
        }
        public override void Display()
        {
            Console.WriteLine("Display: MallardDuck");
        }

    }
}
