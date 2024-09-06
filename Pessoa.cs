using System;
using BancoNamespace;

class Program
{
    static void Main(string[] args)
    {
        Pessoa primeira = new Pessoa(1234, "João", 1000);
        primeira.Depositar(500);
        primeira.Sacar(200);
        primeira.MostrarExtrato();

        PessoaEsp segunda = new PessoaEsp(5678, "Maria", 2000, 3000);
        segunda.Depositar(1000);
        segunda.Sacar(500);
        segunda.MostrarLimite();
        segunda.MostrarExtrato();
    }
}
