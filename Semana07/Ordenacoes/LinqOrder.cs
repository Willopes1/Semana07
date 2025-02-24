﻿using comex.Modelos;

namespace comex.Ordenacoes;

internal class LinqOrder
{
    public static void OrdenarProdutosPorNome(List<Produto> produtos)
    {
        var produtosOrdenados = produtos.OrderBy(produto => produto.Nome).ToList();
        Console.WriteLine("Produtos Ordenados Por Nome:");
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"Produto: {produto.Nome}");
        }
    }

    public static void OrdenarProdutosPorPreco(List<Produto> produtos)
    {
        var produtosOrdenados = produtos.OrderBy(produto => produto.Preco).ToList();
        Console.WriteLine("Produtos Ordenados Por Preço:");
        foreach (var produto in produtosOrdenados)
        {
            Console.WriteLine($"Produto: {produto.Nome} - Preço: {produto.Preco}");
        }
    }

    public static void OrdenarPedidosPorCliente(List<Pedido> pedidos)
    {
        var pedidosOrdenados = pedidos.OrderBy(pedido => pedido.Cliente.Nome).ToList();
        Console.WriteLine("Lista de Pedidos Ordenados Por Cliente:");

        foreach (var pedido in pedidosOrdenados)
        {
            Console.WriteLine(pedido);
        }
    }
}