using Padroes_de_Projeto.RPG_Strategy.Interfaces;
using System;

namespace Padroes_de_Projeto.RPG_Strategy.ComportamentosArmas
{
    public class ComportamentoDeFaca : ComportamentoDeArma
    {
        public void UsarArma()
        {
            Console.WriteLine("Equipando com uma faca");
        }
    }
}
