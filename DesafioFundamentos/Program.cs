using DesafioFundamentos.Models;

// Coloca o encoding para UTF8 para exibir acentuação
Console.OutputEncoding = System.Text.Encoding.UTF8;

decimal precoInicial = 0;
decimal precoPorHora = 0;


Console.WriteLine("Bem-vindo ao controle de estacionamento!");
Console.Write("Informe o valor base (entrada): R$ ");
precoInicial = decimal.TryParse(Console.ReadLine(), out var pi) ? pi : 0;
Console.Write("Informe o valor por hora: R$ ");
precoPorHora = decimal.TryParse(Console.ReadLine(), out var ph) ? ph : 0;

var estacionamento = new Estacionamento(precoInicial, precoPorHora);

while (true)
{
    Console.WriteLine("\nSelecione uma ação:");
    Console.WriteLine("[A] Adicionar veículo");
    Console.WriteLine("[R] Remover veículo");
    Console.WriteLine("[L] Listar veículos");
    Console.WriteLine("[S] Sair");
    Console.Write("Opção: ");
    var escolha = Console.ReadLine()?.Trim().ToUpper();

    switch (escolha)
    {
        case "A":
            estacionamento.AdicionarVeiculo();
            break;
        case "R":
            estacionamento.RemoverVeiculo();
            break;
        case "L":
            estacionamento.ListarVeiculos();
            break;
        case "S":
            Console.WriteLine("Encerrando o sistema. Até logo!");
            return;
        default:
            Console.WriteLine("Opção não reconhecida. Tente novamente.");
            break;
    }
}
