using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Models
{
    class Vendedor
    {
        //Construtor
        public Vendedor(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
        }

        public Vendedor()
        {
            CriadoEm = DateTime.Now;
        }

        //Atributos, propriedades, membros e características
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public DateTime CriadoEm { get; set; }

        //ToString Para mostrar valores na lista
        public override string ToString()
        {
            return $"Nome: {Nome} | CPF: {Cpf} | Criado em: {CriadoEm}";
        }
    }
}
