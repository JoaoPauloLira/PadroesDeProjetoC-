using Padroes_de_Projeto.ChainOfResponsibility;
using Padroes_de_Projeto.Strategy;
using Padroes_de_Projeto.TemplateMethod;
using System;

namespace Padroes_de_Projeto
{
    public class Program
    {
        static void Main(string[] args)
        {
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
    }
}
