using System;
using System.Collections.Generic;
using System.Text;

namespace BancoProjeto.Dominio
{
    public class Cliente
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Cliente(string nome)
        {
            Id = new Guid();
            Nome = nome;
        }
    }
}
