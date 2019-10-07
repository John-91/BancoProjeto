using System;
using Xunit;
using xUnitBanco.Injecao;
using Autofac;
using BancoProjeto.Aplicacao.CasosDeUso;
using BancoProjeto.Dominio;

namespace xUnitBanco
{
    public class UnitTest1 : IClassFixture<Fixture>
    {
        public readonly IExtrato extrato;
        public readonly ISomarSaldo somarSaldo;
        public readonly ISubtrairSaldo subtrairSaldo;
        public readonly ITransferencia transferencia;


        public Cliente cliente1;
        public Cliente cliente2;

        public ContaCorrente conta1;
        public ContaPoupanca conta2;

        public UnitTest1(Fixture fix)
        {
            extrato = fix.ContainerFix.Resolve<IExtrato>();
            somarSaldo = fix.ContainerFix.Resolve<ISomarSaldo>();
            subtrairSaldo = fix.ContainerFix.Resolve<ISubtrairSaldo>();
            transferencia = fix.ContainerFix.Resolve<ITransferencia>();

            cliente1 = new Cliente("John");
            cliente2 = new Cliente("Lua");

            conta1 = new ContaCorrente("4563", "3423234",cliente1);
            conta2 = new ContaPoupanca("4578", "3567234",cliente2);
        }

        [Fact]
        public void TestExtrato()
        {
            conta1.Extrato.AtualizarExtrato("Deposito de R$ 10");
            Assert.True(conta1.Extrato.ExtratoConta[0] == "Deposito de R$ 10");
        }

        [Fact]
        public void TesteSomarSaldo()
        {
            conta1.Saldo.SomarSaldor(25m);
            Assert.True(conta1.Saldo.SaldoConta == 25m);
        }

        [Fact]
        public void TesteSubtrairSaldo()
        {
            conta1.Saldo.SomarSaldor(20m);
            conta1.Saldo.SubtrairSaldo(10m);
            Assert.True(conta1.Saldo.SaldoConta == 10m);
        }

        [Fact]
        public void TesteTransferencia()
        {
            conta1.Saldo.SomarSaldor(20m);
            transferencia.Executar(conta1, conta2, 10m);
            Assert.True(conta1.Saldo.SaldoConta == conta2.Saldo.SaldoConta);
        }
    }
}
