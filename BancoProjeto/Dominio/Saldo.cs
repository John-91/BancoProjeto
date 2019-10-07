using BancoProjeto.Aplicacao.CasosDeUso;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Dominio
{
    public class Saldo : ISomarSaldo, ISubtrairSaldo
    {
        public decimal SaldoConta { get; set; }

        public Saldo()
        {
            SaldoConta = 0m;
        }

        public void SomarSaldor(decimal valor)
        {
            SaldoConta += valor;
        }

        public void SubtrairSaldo(decimal valor)
        {
            SaldoConta -= valor;
        }
    }
}
