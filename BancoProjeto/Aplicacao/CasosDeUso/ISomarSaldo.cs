using BancoProjeto.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Aplicacao.CasosDeUso
{
    public interface ISomarSaldo
    {
        public void SomarSaldor(decimal valor);
    }
}
