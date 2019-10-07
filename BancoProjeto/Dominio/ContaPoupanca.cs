using BancoProjeto.Aplicacao.CasosDeUso;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Dominio
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataAniversario { get; private set; }
        
        public decimal TaxaRendimento { get; private set; }

        public ContaPoupanca(string agencia, string numConta, Cliente cliente)
        {
            Agencia = agencia;
            NumConta = numConta;
            Saldo = new Saldo();
            Cliente = cliente;
            Extrato = new Extrato();

            DataAniversario = DateTime.Now;
            TaxaRendimento = 0.02m;
        }
    }
}
