using System;
using System.Collections.Generic;
using System.Text;
using Vendas.DAL;
using Vendas.Models;
using Vendas.Utils;

namespace Vendas.Views
{
    class CadastrarVendedor
    {
        public static void Renderizar()
        {
            Vendedor v = new Vendedor();
            Console.WriteLine(" --- CADASTRAR VENDEDOR --- \n");
            Console.WriteLine("Digite o nome do vendedor:");
            v.Nome = Console.ReadLine();
            Console.WriteLine("Digite o CPF do vendedor:");
            v.Cpf = Console.ReadLine();

            if (Validacao.ValidarCpf(v.Cpf))
            {
                if (VendedorDAO.Cadastrar(v))
                {
                    Console.WriteLine("\nVendedor cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("\nO vendedor já existe!");
                }
            }
            else
            {
                Console.WriteLine("\nCPF inválido!");
            }
        }
    }
}
