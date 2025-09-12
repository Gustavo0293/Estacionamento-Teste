using praticando_poo;
using Praticando_poo.Models;

bool exibirMenu = true;
Estacionamento estacionamento = new Estacionamento { NumeroVagas = 10 };

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Sistema Estacionamento");
    Console.WriteLine("Escolha uma Ação:");
    Console.WriteLine("1-Adicionar Carro ao Estacionamento");
    Console.WriteLine("2-Buscar Carro");
    Console.WriteLine("3-Excluir Carro");
    Console.WriteLine("4-Carros no Estacionamento");
    Console.WriteLine("5-Exit");

    var opcao = Console.ReadLine();
    switch (opcao)
    {
            case "1":
            Console.Write("Placa: ");
            var placa = Console.ReadLine() ?? "";
            Console.Write("Dono: ");
            var dono = Console.ReadLine() ?? "";
            Console.Write("Modelo: ");
            var modelo = Console.ReadLine() ?? "";

            Automoveis carro = new Automoveis
            {
                PlacaVeiculo = placa,
                NomeDonoCarro = dono,
                ModeloCarro = modelo
            };

            if (estacionamento.AdicionarCarro(carro))
            {
                Console.WriteLine($"Carro adicionado na vaga {carro.Posicao}!");
                
            }
            else
            {
                Console.WriteLine("Estacionamento Cheio, não foi possível adicionar o carro");
            }
            Console.ReadKey();
            break;

        case "2":
            Console.WriteLine("Digite a Placa do Carro: ");
            var buscaPlaca = Console.ReadLine() ?? "";
            var encontrado = estacionamento.BuscarPorPlaca(buscaPlaca);
            if (encontrado != null)
            {
                Console.WriteLine($"Encontrado: Vaga {encontrado.Posicao} - {encontrado.ModeloCarro} (Dono: {encontrado.NomeDonoCarro})");

            }

            else
            {
                Console.WriteLine("Carro não encontrado.");
                
            }
            Console.ReadKey();
            break;

        case "3":
            Console.WriteLine("Digite a Placa do Carro: ");
            var placaCarro = Console.ReadLine() ?? "";
            bool excluido = estacionamento.ExcluirCarro(placaCarro);
            if (excluido)
            {
                Console.WriteLine("Carro Apagado!");

            }
            else
            {
                Console.WriteLine("Erro ao Exclur Carro!");
                
            }
            Console.ReadKey();
                break;

        case "4":
            Console.WriteLine("Os carros presentes no estacionamento são: ");
            estacionamento.ExibirInformacoes();
            Console.ReadKey();
            break;

        case "5":
            Console.WriteLine("Encerrando o Programa");
            exibirMenu = false;
            break;


        default:
            Console.WriteLine("Por favor, preencha corretamente!");
            break;
    }
}