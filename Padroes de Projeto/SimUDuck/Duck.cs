using System;

namespace Padroes_de_Projeto.SimUDuck
{
    public abstract class Duck
    {
        //Grosnar
        public virtual void Quack()
        {
            Console.WriteLine("quack: Grosnar");
        }

        //Nadar 
        public void Swim()
        {
            Console.WriteLine("swin: Nadar");
        }

        //Voar
        public virtual void Fly()
        {
            Console.WriteLine("fly: Voar");
        }

        public abstract void Display();

    }
}
