
namespace ContaCorrente.ConsoleApp
{
    public class ContaCorrente
    {
        public int numeroConta;
        public decimal limite;
        public decimal saldo;
        public decimal[] movimentacoes = new decimal[10];

        public decimal Sacar(decimal valor)
        {
            saldo = saldo - valor;
            return saldo;
        }

        public decimal Depositar(decimal valor)
        {
            saldo = saldo + valor;
            return saldo;
        }

        public decimal TransferirPara(ContaCorrente contaDestino, decimal valor)
        {
            saldo = saldo - valor;
            return saldo;
        }

        public void ExibirExtrato()
        {
            Console.Write($"Número da conta: {numeroConta}");
            Console.WriteLine();
            Console.Write($"Saldo atual: {saldo}");
            Console.WriteLine();
            Console.Write($"Limite: {limite}");
            Console.WriteLine();
            Console.Write($"Movimentações: {movimentacoes}");
            Console.WriteLine();
        }
    }
}
