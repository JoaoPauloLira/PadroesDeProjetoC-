using Padroes_de_Projeto.ChainOfResponsibility;
using Padroes_de_Projeto.RPG_Strategy;
using Padroes_de_Projeto.RPG_Strategy.ComportamentosArmas;
using Padroes_de_Projeto.SimUDuck;
using Padroes_de_Projeto.SimUDuck.Comportamentos;
using Padroes_de_Projeto.StarBuzz_Decorate;
using Padroes_de_Projeto.StarBuzz_Decorate.Bebidas;
using Padroes_de_Projeto.StarBuzz_Decorate.Decoradores;
using Padroes_de_Projeto.Strategy;
using Padroes_de_Projeto.TemplateMethod;
using Padroes_de_Projeto.WeatherData_Observer;
using System;
using Imposto = Padroes_de_Projeto.Strategy.Imposto;
using Orcamento = Padroes_de_Projeto.Strategy.Orcamento;

namespace Padroes_de_Projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (false)
            {
                MainStrategy();
            }

            if (false)
            {
                MainChainOfResponsibility();
            }

            if (false)
            {
                MainTemplateMethod();
            }

            if (false)
            {
                MainDuck();
                return;
            }

            if (false)
            {
                RPG();
                return;
            }

            if (false)
            {
                EstacaoMeteorologicaObserver();
                return;
            }

            if (false)
            {
                EstacaoMeteorologicaObserver();
                return;
            }

            if (true)
            {
                StarBuzzDecorate();
            }
        }

        private static void Divisor()
        {
            Console.WriteLine();
            Console.WriteLine("********************** // **********************");
            Console.WriteLine();
        }

        private static void Imprimir(string valor)
        {
            Console.WriteLine("********************** // **********************");
            Console.WriteLine(valor);
            Console.WriteLine("********************** // **********************");
        }

        private static void MainStrategy()
        {
            Console.WriteLine("Strategy");

            Imposto iss = new ISS();
            Imposto icms = new ICMS();

            var orcamento = new Orcamento(500.0);

            var calculador = new CalculadorDeImpostos();

            calculador.RealizaCalculo(orcamento, icms);
            calculador.RealizaCalculo(orcamento, iss);
            Console.WriteLine("FIM");
        }

        private static void MainChainOfResponsibility()
        {
            Console.WriteLine("Chain Of Responsibility");

            var calculador = new CalculadorDeDescontos();

            var orcamento = new ChainOfResponsibility.Orcamento(500.0);
            orcamento.AdicionaItem(new ChainOfResponsibility.Item("CANETA", 250.0));
            orcamento.AdicionaItem(new ChainOfResponsibility.Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new ChainOfResponsibility.Item("GELADEIRA", 250.0));
            orcamento.AdicionaItem(new ChainOfResponsibility.Item("FOGAO", 250.0));
            orcamento.AdicionaItem(new ChainOfResponsibility.Item("MICROONDAS", 250.0));
            orcamento.AdicionaItem(new ChainOfResponsibility.Item("PS4", 250.0));

            var desconto = calculador.Calcula(orcamento);

            Console.WriteLine(desconto);

            Console.WriteLine("FIM");
        }

        private static void MainTemplateMethod()
        {
            Console.WriteLine("Template Method");

            var orcamento = new TemplateMethod.Orcamento(500.0);
            orcamento.AdicionaItem(new TemplateMethod.Item("CANETA", 250.0));
            orcamento.AdicionaItem(new TemplateMethod.Item("LAPIS", 250.0));
            orcamento.AdicionaItem(new TemplateMethod.Item("GELADEIRA", 250.0));
            orcamento.AdicionaItem(new TemplateMethod.Item("FOGAO", 250.0));
            orcamento.AdicionaItem(new TemplateMethod.Item("MICROONDAS", 250.0));
            orcamento.AdicionaItem(new TemplateMethod.Item("PS4", 250.0));

            var ikcv = new IKCV();
            var icpp = new ICPP();

            Console.WriteLine(ikcv.Calcula(orcamento));
            Console.WriteLine(icpp.Calcula(orcamento));

            Console.WriteLine("FIM");
        }

        private static void EstacaoMeteorologicaObserver()
        {
            var weatherData = new WeatherData();
            var conditionsDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 28.4f);

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

        private static void StarBuzzDecorate()
        {
            Beverage expresso = new Expresso();
            Imprimir($"{expresso.GetDescription()} R$ {expresso.Cost()}");

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Chocolate(darkRoast);
            darkRoast = new Chocolate(darkRoast);
            darkRoast = new Creme(darkRoast);
            Imprimir($"{darkRoast.GetDescription()} R$ {darkRoast.Cost()}");

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soja(houseBlend);
            houseBlend = new Chocolate(houseBlend);
            houseBlend = new Creme(houseBlend);
            Imprimir($"{houseBlend.GetDescription()} R$ {houseBlend.Cost()}");
        }

    }
}
