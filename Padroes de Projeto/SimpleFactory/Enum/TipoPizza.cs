namespace Padroes_de_Projeto.SimpleFactory.Enum
{
    public enum TipoPizza
    {
        Nula = 0,
        Calabresa = 1,
        Mussarela = 2
    }

    public static class ObtemTipoPizza
    {
        public static TipoPizza GeTipoPizza(int indice)
        {
            return indice switch
            {
                1 => TipoPizza.Calabresa,
                2 => TipoPizza.Mussarela,
                _ => TipoPizza.Nula
            };
        }
    }

}
