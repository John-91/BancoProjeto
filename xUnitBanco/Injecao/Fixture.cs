using Autofac;
using BancoProjeto.Aplicacao.CasosDeUso;
using BancoProjeto.Dominio;
using System;
using System.Collections.Generic;
using System.Text;

namespace xUnitBanco.Injecao
{
    public class Fixture
    {
        public IContainer ContainerFix { get; private set; }

        public Fixture()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Extrato>()
                .As<IExtrato>()
                .InstancePerDependency();

            builder.RegisterType<Saldo>()
                .As<ISomarSaldo>()
                .InstancePerDependency();

            builder.RegisterType<Saldo>()
                .As<ISubtrairSaldo>()
                .InstancePerDependency();

            builder.RegisterType<Transferencia>()
                .As<ITransferencia>()
                .InstancePerDependency();

            ContainerFix = builder.Build();
        }
    }
}
