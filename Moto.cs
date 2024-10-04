public class Moto:Veiculo
{
    private bool temBagageiro;

    public void Empinar()
    {
        Console.WriteLine("A moto está empinando");
    }

    public void ExibirInformações()
    {
        Console.WriteLine($"Marca: {marca}\nModelo: {modelo}\nAno de fabricação: {ano}\nTem Bagageiro: {temBagageiro}");
    }

    public Moto(string marca, string modelo, int ano, bool temBagageiro)
    :base(marca, modelo, ano)
    {
        this.temBagageiro = temBagageiro;
    }
}