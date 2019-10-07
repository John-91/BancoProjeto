using BancoProjeto.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Aplicacao.CasosDeUso
{
    public interface ITransferencia
    {
        public void Executar(Conta contaOrigem, Conta contaDestino, decimal valor);
    }
}
