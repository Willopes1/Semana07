﻿using Semana07.Modelos;

namespace comex.Modelos;

internal class Eletronico : Produto
{
    public int Voltagem { get; set; }
    public int Potencia { get; set; }

    public Eletronico(string nome, int quantidade, decimal preco) : base(nome, quantidade, preco)
    {

    }
}
