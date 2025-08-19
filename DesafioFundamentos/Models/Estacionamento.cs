namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.Write("Placa do veículo para entrada: ");
            var placa = Console.ReadLine()?.Trim().ToUpper();
            if (!string.IsNullOrEmpty(placa))
            {
                veiculos.Add(placa);
                Console.WriteLine($"Veículo {placa} registrado.");
            }
            else
            {
                Console.WriteLine("Placa inválida. Tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.Write("Placa do veículo para saída: ");
            var placa = Console.ReadLine()?.Trim().ToUpper();
            if (veiculos.Contains(placa))
            {
                Console.Write("Horas estacionado: ");
                if (int.TryParse(Console.ReadLine(), out int horas) && horas > 0)
                {
                    var valorTotal = precoInicial + precoPorHora * horas;
                    veiculos.Remove(placa);
                    Console.WriteLine($"Veículo {placa} removido. Valor a pagar: R$ {valorTotal:N2}");
                }
                else
                {
                    Console.WriteLine("Quantidade de horas inválida.");
                }
            }
            else
            {
                Console.WriteLine("Veículo não encontrado.");
            }
        }

        public void ListarVeiculos()
        {
            if (veiculos.Count > 0)
            {
                Console.WriteLine("Veículos presentes:");
                foreach (var placa in veiculos)
                {
                    Console.WriteLine($"- {placa}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum veículo registrado no momento.");
            }
        }
    }
}
