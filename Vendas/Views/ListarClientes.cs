using System;
using System.Collections.Generic;
using System.Text;
using Vendas.DAL;
using Vendas.Models;

namespace Vendas.Views
{
    class ListarClientes
    {
        public static void Renderizar()
        {
            Console.WriteLine(" --- LISTAR CLIENTES --- \n");
            foreach (Cliente clienteCadastrado in ClienteDAO.Listar())
            {
                Console.WriteLine(clienteCadastrado);
            }
        }

    }
}
