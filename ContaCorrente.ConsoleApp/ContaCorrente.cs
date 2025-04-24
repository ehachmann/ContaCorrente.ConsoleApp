
namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public int numeroConta;
        public int registroDeMovimentacoes = 0;
        public decimal limite;
        public decimal saldo;
        public decimal saldoInicial;
        public decimal[] movimentacoes = new decimal[10];


        public decimal Sacar(decimal valor)
        {
            saldo = saldo - valor;
            movimentacoes[registroDeMovimentacoes] = - valor;
            return saldo;
        }

        public decimal Depositar(decimal valor)
        {
            saldo = saldo + valor;
            movimentacoes[registroDeMovimentacoes] = valor;
            return saldo;
        }

        public decimal TransferirPara(ContaCorrente contaDestino, decimal valor)
        {
            saldo = saldo - valor;
            contaDestino.saldo = contaDestino.saldo + valor;
            movimentacoes[registroDeMovimentacoes] = - valor;
            return saldo;
        }

        public void ExibirExtrato()
        {
            Console.Write($"Número da conta: {numeroConta}");
            Console.WriteLine();
            Console.Write($"Limite: {limite}");
            Console.WriteLine();
            Console.Write($"Saldo inicial: {saldoInicial}");
            
            Console.WriteLine();

            for (int i = 0; i < movimentacoes.Length; i++)
            {
                if (movimentacoes[i] != 0)
                {
                    Console.WriteLine($"Movimentações: {movimentacoes[i]}");
                }
            }
            
            Console.Write($"Saldo Atual: {saldo}");
            Console.WriteLine();
        }
    }
}
