﻿using System;
using System.Collections.Generic;
using Vendas.DAL;
using Vendas.Models;

namespace Vendas.Views
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.Clear();
                Console.WriteLine(" --- PROJETO DE VENDAS --- \n");
                Console.WriteLine("1 - Cadastrar cliente");
                Console.WriteLine("2 - Listar clientes");
                Console.WriteLine("3 - Cadastrar vendedor");
                Console.WriteLine("4 - Listar vendedores");
                Console.WriteLine("5 - Cadastrar produto");
                Console.WriteLine("6 - Listar produtos");
                Console.WriteLine("0 - Sair\n");
                Console.WriteLine("Escolha uma opção:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (opcao)
                {
                    case 1:
                        CadastrarCliente.Renderizar();
                        break;
                    case 2:
                        ListarClientes.Renderizar();
                        break;
                    case 3:
                        CadastrarVendedor.Renderizar();
                        break;
                    case 4:
                        ListarVendedores.Renderizar();
                        break;
                    case 5:
                        CadastrarProduto.Renderizar();
                        break;
                    case 6:
                        ListarProdutos.Renderizar();
                        break;
                    case 0:
                        Console.WriteLine("\nSaindo...");
                        break;
                    default:
                        Console.WriteLine(" --- OPÇÃO INVÁLIDA ! --- \n");
                        break;
                }
                Console.WriteLine("\nAperte uma tecla para continuar");
                Console.ReadKey();
            } while (opcao != 0);
        }

        
    }
}