using System;
using System.Collections.Generic;

namespace BancoNamespace
{
    public class Banco
    {
        public int NumeroConta { get; set; }
        public string Nome { get; set; }
        public double Saldo { get; set; }
        private List<string> extrato;

        public Banco(int numeroConta, string nome, double saldo)
        {
            NumeroConta = numeroConta;
            Nome = nome;
            Saldo = saldo;
            extrato = new List<string>();
        }

        public void AdicionarTransacao(string descricao, double valor)
        {
            extrato.Add($"{DateTime.Now}: {descricao} - Valor: {valor}, Saldo: {Saldo}");
        }

        public void MostrarExtrato()
        {
            Console.WriteLine("Extrato:");
            foreach (var item in extrato)
            {
                Console.WriteLine(item);
            }
        }

        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente");
                return;
            }
            Saldo -= valor;
            AdicionarTransacao($"Saque realizado por {Nome}", -valor);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            AdicionarTransacao($"Depósito realizado por {Nome}", valor);
        }
    }
}
