using Padroes_de_Projeto.ChainOfResponsibility;
using Padroes_de_Projeto.SimUDuck;
using Padroes_de_Projeto.Strategy;
using Padroes_de_Projeto.TemplateMethod;
using System;

namespace Padroes_de_Projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (true)
            {
                MainDuck();
                return;
            }

            #region Strategy
            var strategy = new MainStrategy();
            #endregion

            Divisor();

            #region ClainOfResponsibility
            var clainOfResponsibility = new MainChainOfResponsibility();
            #endregion

            Divisor();

            #region TemplateMethod
            var templateMethod = new MainTemplateMethod();
            #endregion

        }

        private static void Divisor()
        {
            Console.WriteLine();
            Console.WriteLine("********************** // **********************");
            Console.WriteLine();
        }

        private static void MainDuck()
        {
            Duck patoBravo = new MallardDuck();
            Duck redhead = new RedheadDuck();
            Duck rubber = new RubberDuck();
            Duck decoy = new DecoyDuck();

            patoBravo.Display();
            patoBravo.Swim();
            patoBravo.Fly();
            patoBravo.Quack();

            Divisor();

            redhead.Display();
            redhead.Swim();
            redhead.Fly();
            redhead.Quack();

            Divisor();

            rubber.Display();
            rubber.Swim();
            rubber.Fly();
            rubber.Quack();

            Divisor();

            decoy.Display();
            decoy.Swim();
            decoy.Fly();
            decoy.Quack();


        }
    }
}
