using BancoProjeto.Aplicacao.CasosDeUso;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Dominio
{
    public class ContaCorrente : Conta
    {
        public DateTime DiaCobrancaTaxa { get; set; }
        public decimal TaxaMensal { get; set; }
        
        public ContaCorrente(string agencia, string numConta, Cliente cliente)
        {
            Agencia = agencia;
            NumConta = numConta;
            Saldo = new Saldo();
            Cliente = cliente;
            Extrato = new Extrato();

            DiaCobrancaTaxa = DateTime.Now;
            TaxaMensal = 5m;
        }
    }
}
