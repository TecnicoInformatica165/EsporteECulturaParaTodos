using System.Runtime.CompilerServices;

namespace EsporteECultura.Core;

public class Endereco
{
    public string Logradouro { get; private set; }
    public string CEP { get; private set; }
    public string Numero { get; private set; }
    public string Complemento { get; private set; }
    public string Cidade { get; private set; }
    public string Bairro { get; private set; }
    public string UF { get; private set; }

    public Endereco(string logradouro, string cidade, string bairro, string UF, string CEP, string complemento,
        string numero)
    {
        ValidarLogradouro(logradouro);
        ValidarCidade(cidade);
        ValidarBairro(bairro);
        ValidarUF(UF);
        ValidarCEP(CEP);
        ValidarComplemento(complemento);
       ValidarNumero(numero);
    }

    private void ValidarLogradouro(string logradouro)
    {
        if (string.IsNullOrWhiteSpace(logradouro))
            throw new Exception();

        Logradouro = logradouro;
    }
    
    private void ValidarCidade(string cidade)
    {
        if (string.IsNullOrWhiteSpace(cidade))
            throw new Exception();

        Cidade = cidade;
    }
    
    private void ValidarBairro(string bairro)
    {
        if (string.IsNullOrWhiteSpace(bairro))
            throw new Exception();

        Bairro = bairro;
    }
    
    private void ValidarUF(string UF)
    {
        if (string.IsNullOrWhiteSpace(UF))
            throw new Exception();

        UF = UF;
    }
    
    private void ValidarCEP(string CEP)
    {
        if (string.IsNullOrWhiteSpace(CEP))
            throw new Exception();

        CEP = CEP;
    }
    
    private void ValidarComplemento(string complemento)
    {
        if (string.IsNullOrWhiteSpace(complemento))
            throw new Exception();

        Complemento = complemento;
    }
    
    private void ValidarNumero(string numero)
    {
        if (string.IsNullOrWhiteSpace(numero))
            throw new Exception();

        Numero = numero;
    }
}