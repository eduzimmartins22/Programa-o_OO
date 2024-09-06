using BancoNamespace;

namespace BancoNamespace
{
    public class PessoaEsp : Pessoa
    {
        public int LimiteCartao { get; set; }

        public PessoaEsp(int numeroConta, string nome, double saldo, int limiteCartao)
            : base(numeroConta, nome, saldo)
        {
            LimiteCartao = limiteCartao;
        }

        public void MostrarLimite()
        {
            Console.WriteLine($"Seu limite de cartão é {LimiteCartao}");
        }
    }
}
