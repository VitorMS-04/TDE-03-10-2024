public class Carro:Veiculo
{
    private int numeroPortas;
    
    public void AbrirPortaMalas()
    {
        Console.WriteLine("O porta-malas está aberto");
    }

    public void ExibirInformações()
    {
        Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno de Fabricação: {ano}\nNúmero de Portas: {numeroPortas}");
    }

    public Carro(string marca, string modelo, int ano, int numeroPortas)
    :base(marca, modelo, ano)
    {
        this.numeroPortas = numeroPortas;
    }
}