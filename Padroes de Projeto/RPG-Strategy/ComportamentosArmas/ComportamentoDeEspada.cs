using Padroes_de_Projeto.RPG_Strategy.Interfaces;
using System;

namespace Padroes_de_Projeto.RPG_Strategy.ComportamentosArmas
{
    public class ComportamentoDeEspada : ComportamentoDeArma
    {
        public void UsarArma()
        {
            Console.WriteLine("Equipando com uma espada");
        }
    }
}
