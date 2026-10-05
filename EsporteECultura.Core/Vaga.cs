namespace EsporteECultura.Core;

public class Vaga
{
    public Vaga(int vagas)
    {
        Vagas = vagas;
    }

    public int Vagas { get; set; }

    public int Disponiveis { get; set; }

    public void Inscrever(Usuario usuario)
    {
        var cliente = new Cliente("Gabriel", "27999999999", "gaga0123", new Endereco("Avenida Talma Rodrigues"));
    }
}