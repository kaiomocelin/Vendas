using System;
using System.Collections.Generic;
using System.Text;

namespace Vendas.Utils
{
    class Validacao
    {
        public static bool ValidarTamanhoCpf(string cpf) => cpf.Length != 11;
        public static bool ValidarCpf(string cpf)
        {
            int peso = 10, soma = 0, resto = 0, digito1;
            cpf = cpf.Replace(".", "").Replace("-", "");
            
            if (ValidarTamanhoCpf(cpf))
            {
                return false;
            }

            switch (cpf)
            {
                case "11111111111": return false;
                case "22222222222": return false;
                case "33333333333": return false;
                case "44444444444": return false;
                case "55555555555": return false;
                case "66666666666": return false;
                case "77777777777": return false;
                case "88888888888": return false;
                case "99999999999": return false;
                case "00000000000": return false;
            }

            //Digito 1
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;
            // if ternario: 
            digito1 = resto < 2 ? 0 : 11 - resto;
            //if (resto < 2)
            //    digito1 = 0;
            // else
            //    digito1 = 11 - resto;
            if (Convert.ToInt32(cpf[9].ToString()) != digito1)
            {
                return false;
            }

            //Digito 2
            soma = 0; peso = 11; int digito2;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString()) * peso;
                peso--;
            }
            resto = soma % 11;

            digito2 = resto < 2 ? 0 : 11 - resto;
           
            if (Convert.ToInt32(cpf[10].ToString()) != digito2)
            {
                return false;
            }
            return true;
        }
    }
}
