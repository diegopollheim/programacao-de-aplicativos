using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCadastro.Entidades
{
    public class Conta
    {
        public string Numero { get; private set; }
        public string Agencia { get; private set; }
        public string Cliente { get; private set; }
        public double Saldo { get; private set; }

        public Conta(string numero, string agencia, string cliente, double saldo)
        {
            Numero = numero;
            Agencia = agencia;
            Cliente = cliente;
            Saldo = saldo;
        }
    }
}
