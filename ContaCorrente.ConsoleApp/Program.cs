namespace ContaCorrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta1 = new ContaCorrente();

            conta1.saldoInicial = conta1.saldo = 1200;
            conta1.numeroConta = 11;
            conta1.limite = 1000;
            conta1.movimentacoes = new decimal[10];
            conta1.registroDeMovimentacoes = 0;

            conta1.movimentacoes[0] = 1000;
            conta1.Sacar(200);
            conta1.registroDeMovimentacoes = 1;
            conta1.Depositar(300);
            conta1.registroDeMovimentacoes = 2;
            conta1.Depositar(500);
            conta1.registroDeMovimentacoes = 3;


            ContaCorrente conta2 = new ContaCorrente();
            
            conta2.saldoInicial = conta2.saldo = 300;
            conta2.numeroConta = 12;
            conta2.limite = 1000;
            conta2.movimentacoes = new decimal[10];

            conta1.TransferirPara(conta2, 400);
          
            conta1.ExibirExtrato();

            Console.WriteLine();

            conta2.ExibirExtrato();

            Console.ReadKey();

        }
    }
}
