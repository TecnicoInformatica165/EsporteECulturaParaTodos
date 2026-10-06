using EsporteECultura.Core;

namespace EsporteECultura.Core;

public class Endereco
{
    public string Logradouro { get; private set; }
    public string CEP { get; private set; }
    public string Numero { get; private set; }    
    public string Complemento  { get; private set; }    
    public string Cidade { get; private set; }
    public string Bairro  { get; private set; }
    public string UF { get; private set; }

    public Endereco(string logradouro, string cidade, string bairro, string UF, string CEP, string complemento, string numero)
    {
        Logradouro = logradouro;
        Cidade = cidade;
        Bairro = bairro;
        UF = UF;
        CEP = CEP;
        Complemento = complemento;
        Numero = numero;
    }
}