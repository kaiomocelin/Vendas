using System;
using System.Collections.Generic;
using System.Text;
using Vendas.Models;

namespace Vendas.DAL
{
    class VendedorDAO
    {
        private static List<Vendedor> vendedores = new List<Vendedor>();

        public static List<Vendedor> Listar() => vendedores;

        public static Vendedor BuscarPorCpf(string cpf)
        {
            foreach (Vendedor vendedorCadastrado in vendedores)
            {
                if (vendedorCadastrado.Cpf == cpf)
                {
                    return vendedorCadastrado;
                }

            }
            return null;
        }
        public static bool Cadastrar(Vendedor vendedor)
        {
            if (BuscarPorCpf(vendedor.Cpf) == null)
            {
                vendedores.Add(vendedor);
                return true;
            }
            return false;
        }
    }
}
