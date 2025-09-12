namespace praticando_poo;

public class CadastroCarro : Automoveis
{
    
    public void Cadastrar(string placa, string dono, string modelo, int posicao)
    {
        PlacaVeiculo = placa;
        NomeDonoCarro = dono;
        ModeloCarro = modelo;
        this.Posicao = posicao;
    }
}
