using System;

namespace Padroes_de_Projeto.SimUDuck
{
    //Pato de Madeira
    public class DecoyDuck : Duck
    {
        //Não Grosna
        public override void Quack()
        {
            //Console.WriteLine("Quack: faz nada");
        }

        //Não Voa
        public override void Fly()
        {
            //Console.WriteLine("Fly: faz nada");
        }

        public override void Display()
        {
            Console.WriteLine("Display: DecoyDuck");
        }
    }
}
