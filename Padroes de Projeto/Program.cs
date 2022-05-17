using Padroes_de_Projeto.ChainOfResponsibility;
using Padroes_de_Projeto.RPG_Strategy;
using Padroes_de_Projeto.RPG_Strategy.ComportamentosArmas;
using Padroes_de_Projeto.SimUDuck;
using Padroes_de_Projeto.SimUDuck.Comportamentos;
using Padroes_de_Projeto.Strategy;
using Padroes_de_Projeto.TemplateMethod;
using System;

namespace Padroes_de_Projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                MainDuck();
                return;
            }

            if (true)
            {
                RPG();
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

        private static void RPG()
        {
            Personagem rei = new Rei();
            rei.Figth();
            rei.SetComportamentoDeArma(new ComportamentoDeEspada());
            rei.Figth();

            Divisor();

            Personagem rainha = new Rainha();
            rainha.Figth();
            rainha.SetComportamentoDeArma(new ComportamentoDeArcoFlecha());
            rainha.Figth();

            Divisor();

            Personagem cavalheiro = new Cavalheiro();
            cavalheiro.Figth();
            cavalheiro.SetComportamentoDeArma(new ComportamentoMachado());
            cavalheiro.Figth();

            Divisor();

            Personagem provocador = new Provocador();
            provocador.Figth();
            provocador.SetComportamentoDeArma(new ComportamentoDeFaca());
            provocador.Figth();
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
            //patoBravo.Fly();
            //patoBravo.Quack();
            patoBravo.PerformFly();
            patoBravo.PerformQuack();


            Divisor();

            redhead.Display();
            redhead.Swim();
            //redhead.Fly();
            //redhead.Quack();

            Divisor();

            rubber.Display();
            rubber.Swim();
            //rubber.Fly();
            //rubber.Quack();

            Divisor();

            decoy.Display();
            decoy.Swim();
            //decoy.Fly();
            //decoy.Quack();

            Divisor();

            Duck modeloDuck = new ModelDuck();

            modeloDuck.Display();
            modeloDuck.PerformFly();
            modeloDuck.SetFlyBehavior(new FlyRocketPowered());
            modeloDuck.PerformFly();

            Divisor();

            var cacadorComDispositivo = new CacadorComDispositivo();
            cacadorComDispositivo.Quack();

        }
    }
}
