using System;
using System.Collections.Generic;
using System.Text;
using Vendas.DAL;
using Vendas.Models;

namespace Vendas.Views
{
    class ListarProdutos
    {
        public static void Renderizar()
        {
            Console.WriteLine(" --- LISTAR PRODUTOS --- \n");
            foreach (Produto produtoCadastrado in ProdutoDAO.Listar())
            {
                Console.WriteLine(produtoCadastrado);
            }
        }
    }
}
