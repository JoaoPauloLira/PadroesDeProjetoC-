﻿namespace Padroes_de_Projeto.TemplateMethod
{
    public class Item
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

        public Item(string nome, double valor)
        {
            Nome = nome;
            Valor = valor;
        }
    }
}
