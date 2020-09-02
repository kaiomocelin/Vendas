using System;
using System.Collections.Generic;
using System.Text;
using Vendas.DAL;

namespace Vendas.Models
{
    class Dados
    {
        public static void Inicializar()
        {
            Cliente cliente = new Cliente
            {
                Nome = "Kaio Mocelin",
                Cpf = "09482201981"
            };
            ClienteDAO.Cadastrar(cliente);

            Produto produto = new Produto
            {
                Nome = "Bolacha",
                Preco = 2.50,
                Quantidade = 20
            };
            ProdutoDAO.Cadastrar(produto);

            Vendedor vendedor = new Vendedor
            {
                Nome = "João",
                Cpf = "975.045.010-85"
            };
            VendedorDAO.Cadastrar(vendedor);
        }
    }
}
