
namespace ContaCorrente.ConsoleApp
{
    public class Movimentacao
    {
        public decimal valor;
        public string tipo;

        public string ExibirMovimentacao()
        {
            return $"Tipo: {tipo} - {valor.ToString("C2")}";
        }

    }
}

