using BancoProjeto.Dominio;
using System;

namespace BancoProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Selecionar();

            static void Selecionar()
            {
                Cliente cliente = new Cliente("Bem vindo Jonathan");
                Saldo saldo = new Saldo();
                Console.WriteLine(cliente.Nome);
            }
            //Console.WriteLine("Hello World!");
        }
    }
}
