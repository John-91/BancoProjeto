using BancoProjeto.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Aplicacao.CasosDeUso
{
    public interface ISubtrairSaldo
    {
        public void SubtrairSaldo(decimal valor);
    }
}
