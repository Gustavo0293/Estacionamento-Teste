using praticando_poo;

namespace Praticando_poo.Models
{
    public class Estacionamento
    {
        public int NumeroVagas { get; set; }
        private List<Automoveis> Carros = new List<Automoveis>();

        public bool AdicionarCarro(Automoveis carro)
        {
            if (Carros.Count > NumeroVagas)
            {
                Console.WriteLine("O Estacionamento já está cheio!");
                return false;
            }
            carro.Posicao = Carros.Count + 1;
            Carros.Add(carro);
            return true;
            
        }
        
        public Automoveis? BuscarPorPlaca(string placa)
        {
            return Carros.Find(c => c.PlacaVeiculo == placa);
        }

        public bool ExcluirCarro(string placa)
        {
            var carro = BuscarPorPlaca(placa);
            if (carro != null)
            {
                Carros.Remove(carro);
                return true;
            }
            return false;
        }

        public int NumeroCarros()
        {
            return Carros.Count;
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Vagas:{NumeroVagas} | Carros estacionados: {NumeroCarros()}");
            foreach (var carro in Carros)
            {
                Console.WriteLine($"Vaga {carro.Posicao}: {carro.ModeloCarro} - {carro.PlacaVeiculo} (Dono: {carro.NomeDonoCarro})");
            }


        }
         


    }
}