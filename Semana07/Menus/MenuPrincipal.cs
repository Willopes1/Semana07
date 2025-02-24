﻿namespace comex.Menus;

internal class MenuPrincipal
{
    public virtual void Executar()
    {
        Dictionary<int, MenuPrincipal> opcao = new();
        opcao.Add(1, new MenuCriarProduto());
        opcao.Add(2, new MenuListarProduto());
        opcao.Add(3, new MenuCriarPedido());
        opcao.Add(4, new MenuListarPedido());
        opcao.Add(5, new MenuSair());

        Console.WriteLine("Escolha uma opção:");
        Console.WriteLine("1 - Criar Produto");
        Console.WriteLine("2 - Listar Produtos");
        Console.WriteLine("3 - Criar Pedido");
        Console.WriteLine("4 - Listar Pedidos");
        Console.WriteLine("5 - Sair\n");
        string leOpcao = Console.ReadLine()!;
        int leOpcaoNumerica = int.Parse(leOpcao);

        if (opcao.ContainsKey(leOpcaoNumerica))
        {
            MenuPrincipal menuPrincipal = opcao[leOpcaoNumerica];
            menuPrincipal.Executar();

            if (leOpcaoNumerica != 5)
            {
                Executar();
            }
        }
        else
        {
            Console.WriteLine("Opção Inválida");
        }
    }
}
