using System;
using System.Collections.Generic;
using System.Text;
using Vendas.DAL;
using Vendas.Models;

namespace Vendas.Views
{
    class ListarVendedores
    {
        public static void Renderizar()
        {
            Console.WriteLine(" --- LISTAR VENDEDORES --- \n");
            foreach (Vendedor vendedorCadastrado in VendedorDAO.Listar())
            {
                Console.WriteLine(vendedorCadastrado);
            }
        }
    }
}
