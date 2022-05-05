using System;

namespace Padroes_de_Projeto.SimUDuck
{
    //Pato de borracha
    public class RubberDuck : Duck
    {
        //Sobrescreve o Grosnar por um apito do pato de borracha
        public override void Quack()
        {
            Console.WriteLine("squeak: Grosnar(Apito)");
        }

        public override void Display()
        {
            Console.WriteLine("Display: RubberDuck");
        }
    }
}
