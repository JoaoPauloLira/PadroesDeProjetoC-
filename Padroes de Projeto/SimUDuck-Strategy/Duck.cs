using Padroes_de_Projeto.SimUDuck.Interfaces;
using System;

namespace Padroes_de_Projeto.SimUDuck
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public abstract void Display();


        //Nadar 
        public void Swim()
        {
            Console.WriteLine("swin: Nadar");
        }

        public void PerformQuack()
        {
            _quackBehavior.quack();
        }

        public void PerformFly()
        {
            _flyBehavior.Fly();
        }

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackBehavior(IQuackBehavior quackBehavior)
        {
            _quackBehavior = quackBehavior;
        }

        //Saio daquei e foi para as classes de comportamento que implementa a IQuackBehavior
        ////Grosnar
        //public virtual void Quack()
        //{
        //    Console.WriteLine("quack: Grosnar");
        //}

        //Saio daquei e foi para as classes de comportamento que implementa a IFlyBehavior
        ////Voar
        //public virtual void Fly()
        //{
        //    Console.WriteLine("fly: Voar");
        //}



    }
}
