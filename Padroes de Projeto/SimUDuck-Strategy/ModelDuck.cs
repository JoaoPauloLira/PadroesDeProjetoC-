using Padroes_de_Projeto.SimUDuck.Comportamentos;
using System;

namespace Padroes_de_Projeto.SimUDuck
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackBehavior = new Quack();
        }

        public override void Display()
        {
            Console.WriteLine("Display: ModelDuck");
        }
    }
}
