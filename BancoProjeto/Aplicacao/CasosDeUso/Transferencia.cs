using System;
using System.Collections.Generic;
using System.Text;
using BancoProjeto.Dominio;

namespace BancoProjeto.Aplicacao.CasosDeUso
{
    public class Transferencia : ITransferencia
    {
        public void Executar(Conta contaOrigem, Conta contaDestino, decimal valor)
        {
            contaOrigem.Saldo.SubtrairSaldo(valor);
            contaDestino.Saldo.SomarSaldor(valor);
            contaOrigem.Extrato.AtualizarExtrato("Transferencia do valor");
            contaDestino.Extrato.AtualizarExtrato("Recebido transferencia do valor");
        }
    }
}
