
namespace ContaCorrente.ConsoleApp
{
    

    public class ContaCorrente
    {
        // atributos
        public int numeroConta;
        public decimal limite;
        public decimal saldo;
        public Movimentacao[] movimentacoes;
        int contadorMovimentacoes = 0;

        // métodos
        public void Sacar(decimal valor)
        {
            if (valor <= saldo + limite) 
            {
                saldo -= valor;

                Movimentacao novaMovimentacao = new Movimentacao();
                novaMovimentacao.valor = valor;
                novaMovimentacao.tipo = "Débito";

                movimentacoes[contadorMovimentacoes] = novaMovimentacao;
                contadorMovimentacoes++;
            }
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;

            Movimentacao novaMovimentacao = new Movimentacao();
            novaMovimentacao.valor = valor;
            novaMovimentacao.tipo = "Crédito";

            movimentacoes[contadorMovimentacoes] = novaMovimentacao;
            contadorMovimentacoes++;
        }

        public void TransferirPara(ContaCorrente contaDestino, decimal valor)
        {
            contaDestino.Depositar(valor);
            this.Sacar(valor);
        }

        public void ExibirExtrato()
        {
            Console.WriteLine("Extrato da Conta #" + this.numeroConta);

            Console.WriteLine("Saldo: " + this.saldo);

            Console.WriteLine();

            for (int i = 0; i < movimentacoes.Length; i++)
            {
                Movimentacao movimentacaoAtual = movimentacoes[i];

                if (movimentacaoAtual != null)
                {
                    Console.WriteLine(movimentacaoAtual.ExibirMovimentacao());
                }
            }
        }
    }
}
