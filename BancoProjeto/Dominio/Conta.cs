using BancoProjeto.Aplicacao.CasosDeUso;
using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Dominio
{
    public abstract class Conta
    {
        public string Agencia { get; protected set; }
        public string NumConta { get; protected set; }
        public Saldo Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }
        public Extrato Extrato { get; protected set; }
    }
}
