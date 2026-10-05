namespace EsporteECultura.Core;

public class Endereco
{
    public string Logradouro { get; private set; }
    public string Bairro  { get; private set; }
    public string UF { get; private set; }

    public Endereco(string logradouro)
    {
        Logradouro = logradouro;
    }
}